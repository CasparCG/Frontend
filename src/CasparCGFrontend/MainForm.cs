using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.Diagnostics;
using Settings = CasparCGFrontend.Properties.Settings;
using Timer = System.Threading.Timer;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace CasparCGFrontend
{
    public partial class MainForm : Form
    {
        private bool ignoreEvents = false;
        private int dueTime = 3;
        private Process process;
        private AbstractConsumer lastConsumer;
        public configuration config = new configuration();
        private ConsumerControlBase consumerEditorControl;
        public List<String> availableDecklinkIDs = new List<string>();

        private DateTime StartTime { get; set; }
        private Timer StatusTimer { get; set; }
        private Timer TimeTimer { get; set; }

        private string ServerVersion { get; set; }
        private string FreeImageVersion { get; set; }
        private string FFmpegAVCodecVersion { get; set; }
        private string FFmpegAVFormatVersion { get; set; }
        private string FFmpegAVFilterVersion { get; set; }
        private string FFmpegAVUtilVersion { get; set; }
        private string FFmpegSWScaleVersion { get; set; }
        private string FlashVersion { get; set; }
        private string TemplatehostVersion { get; set; }

        private delegate bool CheckForSaveCallback();
        private delegate void UpdateStatusCallback(bool isRunning);
        private delegate void UpdateUptimeCallback(bool isRunning);
        private delegate void ProcessOutputDataCallback(object sender, DataReceivedEventArgs e);
        private delegate void RestartProcessCallback(object sender, EventArgs e);

        public MainForm()
        {
            this.InitializeComponent();

            this.Text += " " + Settings.Default.Version;

            this.tabControl.SelectedTab = this.tabPageStatus;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(string.Format("{0}\\casparcg.config", Path.GetDirectoryName(Settings.Default.ServerPath))))
            {
                DeSerializeConfig(File.ReadAllText(string.Format("{0}\\casparcg.config", Path.GetDirectoryName(Settings.Default.ServerPath))));
            }
            else
            {
                MessageBox.Show("A 'casparcg.config' file was not found in the same directory as this application. One is now being generated.", "CasparCG Frontend", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SerializeConfig();
            }
            this.WireBindings();
            this.Updatechannel();

            StartServer();
        }

        private void DockControls()
        {
            this.panelStatus.Dock = DockStyle.Fill;
            this.panelPaths.Dock = DockStyle.Fill;
            this.panelChannels.Dock = DockStyle.Fill;
            this.panelAdvanced.Dock = DockStyle.Fill;
            this.panelConsole.Dock = DockStyle.Fill;
        }

        private bool ProcessExists(string name)
        {
            return (Process.GetProcessesByName(name).Length > 0);
        }

        private void TerminateProcess(string name)
        {
            Process.GetProcessesByName(name).ToList().ForEach(p => p.Kill());
        }

        private void StartServer()
        {
            this.statusLabel.Text = "Initializing...";

            if (ProcessExists("casparcg"))
                TerminateProcess("casparcg");

            this.process = new Process();
            this.process.EnableRaisingEvents = true;
            this.process.StartInfo.FileName = Settings.Default.ServerPath;
            this.process.StartInfo.WorkingDirectory = Path.GetDirectoryName(Settings.Default.ServerPath);
            this.process.StartInfo.CreateNoWindow = true;
            this.process.StartInfo.UseShellExecute = false;
            this.process.StartInfo.RedirectStandardOutput = true;
            this.process.StartInfo.RedirectStandardInput = true;
            this.process.OutputDataReceived += new DataReceivedEventHandler(OnProcessOutputData);

            this.process.Exited += new EventHandler(process_Exited);

            this.process.Start();
            this.process.BeginOutputReadLine();

            this.StatusTimer = new Timer(CheckStatus, null, this.dueTime * 1000, 3000);

            this.StartTime = DateTime.Now;
            this.TimeTimer = new Timer(CheckUptime, null, this.dueTime * 1000, 1000);
        }

        private void process_Exited(object sender, EventArgs e)
        {
            if (this.process.ExitCode == 5)
            {
                if (this.InvokeRequired)
                {
                    this.BeginInvoke(new RestartProcessCallback(process_Exited), sender, e);
                }
                else
                {
                    UpdateStatus(false);
                    this.textBoxLog.Clear();

                    StartServer();
                }
            }
        }

        private void StopServer()
        {
            if (this.TimeTimer != null)
                this.TimeTimer.Dispose();
            
            if (this.StatusTimer != null)
                this.StatusTimer.Dispose();

            if (this.process != null)
            {
                this.process.OutputDataReceived -= new DataReceivedEventHandler(OnProcessOutputData);

                if (this.process.IsRunning())
                {
                    this.process.StandardInput.Write("KILL\r\n");
                    this.process.WaitForExit();
                }
            }
        }

        private void SaveStatus(object state)
        {
            try
            {
                CheckForSave();
            }
            catch (Exception ex) { }
        }

        private void CheckStatus(object state)
        {
            try
            {
                UpdateStatus(ProcessExtensions.IsRunning(this.process)); 
            }
            catch (Exception ex) { }
        }

        private void CheckUptime(object state)
        {
            try
            {
                UpdateUptime(ProcessExtensions.IsRunning(this.process)); 
            }
            catch (Exception ex) { }
        }

        private void OnProcessOutputData(object sender, DataReceivedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new ProcessOutputDataCallback(OnProcessOutputData), sender, e);
            }
            else
            {
                if (e.Data != null)
                {
                    if (e.Data.Contains("Starting CasparCG"))
                        this.ServerVersion = LogParser.ParseServerVersion(e.Data);
                    else if (e.Data.Contains("FreeImage "))
                        this.FreeImageVersion = LogParser.ParseComponentVersion(e.Data);
                    else if (e.Data.Contains("FFMPEG-avcodec "))
                        this.FFmpegAVCodecVersion = LogParser.ParseComponentVersion(e.Data);
                    else if (e.Data.Contains("FFMPEG-avformat "))
                        this.FFmpegAVFormatVersion = LogParser.ParseComponentVersion(e.Data);
                    else if (e.Data.Contains("FFMPEG-avfilter "))
                        this.FFmpegAVFilterVersion = LogParser.ParseComponentVersion(e.Data);
                    else if (e.Data.Contains("FFMPEG-avutil "))
                        this.FFmpegAVUtilVersion = LogParser.ParseComponentVersion(e.Data);
                    else if (e.Data.Contains("FFMPEG-swscale "))
                        this.FFmpegSWScaleVersion = LogParser.ParseComponentVersion(e.Data);
                    else if (e.Data.Contains("Flash Not found"))
                        this.FlashVersion = "Not found";
                    else if (e.Data.Contains("Flash "))
                        this.FlashVersion = LogParser.ParseComponentVersion(e.Data);
                    else if (e.Data.Contains("Template-Host Unknown"))
                        this.TemplatehostVersion = "Unknown";
                    else if (e.Data.Contains("Template-Host "))
                        this.TemplatehostVersion = LogParser.ParseComponentVersion(e.Data);

                    this.textBoxLog.AppendText(e.Data + "\r\n");
                    Interop.ScrollToBottom(this.textBoxLog);
                }
            }
        }

        private void UpdateUptime(bool isRunning)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new UpdateUptimeCallback(UpdateUptime), isRunning);
            }
            else
            {
                if (isRunning)
                {
                    TimeSpan difference = DateTime.Now.AddSeconds(-this.dueTime) - this.StartTime;
                    this.labelUptime.Text = string.Format("Uptime {0}", difference.ToString(@"dd\:hh\:mm\:ss"));
                }
            }
        }

        private void UpdateStatus(bool isRunning)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new UpdateStatusCallback(UpdateStatus), isRunning);
            }
            else
            {
                if (isRunning)
                {
                    this.labelStatus.ForeColor = Color.Lime;
                    this.labelStatus.Text = "\n\n\n\n\n\nOnline";
                    this.labelServerVersion.Text = "CasparCG " + this.ServerVersion;
                    this.labelComponentVersion.Text = string.Format("FreeImage {0}, FFmpeg AVCodec {1}, FFmpeg AVFormat {2}\n" +
                                                                    "FFMPEG AVFilter {3}, FFmpeg AVUtil {4}, FFmpeg SWScale {5}\n" +
                                                                    "Flash {6}, Templatehost {7}",
                                                                    this.FreeImageVersion, this.FFmpegAVCodecVersion, this.FFmpegAVFormatVersion,
                                                                    this.FFmpegAVFilterVersion, this.FFmpegAVUtilVersion, this.FFmpegSWScaleVersion,
                                                                    this.FlashVersion, this.TemplatehostVersion);

                    this.statusLabel.Text = "Ready";

                    this.buttonStart.Enabled = false;
                    this.buttonStop.Enabled = true;
                    this.buttonRestart.Enabled = true;
                    this.buttonChannelGrid.Enabled = true;
                    this.buttonDiag.Enabled = true;
                    this.buttonThumbnails.Enabled = true;
                }
                else
                {
                    this.labelStatus.ForeColor = Color.FromArgb(190, 190, 190);
                    this.labelStatus.Text = "\n\n\n\n\n\nOffline";
                    this.labelServerVersion.Text = "";
                    this.labelComponentVersion.Text = "";

                    this.statusLabel.Text = "";
                    this.labelUptime.Text = "";

                    this.buttonStart.Enabled = true;
                    this.buttonStop.Enabled = false;
                    this.buttonRestart.Enabled = false;
                    this.buttonChannelGrid.Enabled = false;
                    this.buttonDiag.Enabled = false;
                    this.buttonThumbnails.Enabled = false;
                }
            }
        }
        
        private void WireBindings()
        {
            this.pathsBindingSource.DataSource = this.config.Paths;
            this.flashBindingSource.DataSource = this.config.Flash;
            this.mixerBindingSource.DataSource = this.config.Mixer;
            this.oscBindingSource.DataSource = this.config.Osc;
            this.thumbnailBindingSource.DataSource = this.config.Thumbnails;
            this.configurationBindingSource.DataSource = this.config;
            this.listBox1.DataSource = this.config.Channels;
            this.listBox4.DataSource = this.config.Osc.PredefinedClients;
        }

        private void SerializeConfig()
        {
            var extraTypes = new Type[1]{typeof(AbstractConsumer)};

            XDocument doc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"));
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            using(var writer = doc.CreateWriter())
            {
                new XmlSerializer(typeof(configuration), extraTypes).Serialize(writer, config, namespaces);
            }

            doc.Element("configuration").Add(
                new XElement("controllers",
                    new XElement("tcp",
                        new XElement[2]
                        {
                            new XElement("port", 5250),
                            new XElement("protocol", "AMCP")
                        })));

            doc.Add(new XComment(CasparCGFrontend.Properties.Resources.configdoc.ToString()));

            using (var writer = new XmlTextWriter(string.Format("{0}\\casparcg.config", Path.GetDirectoryName(Settings.Default.ServerPath)), new UTF8Encoding(false, false))) // No BOM
            {
                writer.Formatting = Formatting.Indented;
                doc.Save(writer);
            }
        }
        
        private void DeSerializeConfig(string text)
        {
            var x = new XmlSerializer(typeof(configuration));

            using (var reader = new StringReader(text))
            {
                XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
                namespaces.Add(string.Empty, string.Empty);

                try
                {
                    this.config = (configuration)x.Deserialize(reader);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error reading the current 'casparcg.config' file. A new one will be generated.", "CasparCG Frontend", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    this.config = new configuration();
                }
            }
            this.WireBindings();
        }

        private void RefreshConsumerPanel()
        {
            if (lastConsumer != listBox2.SelectedItem)
            {

                this.panelOutput.Controls.Clear();
                if (consumerEditorControl != null)
                    consumerEditorControl.Dispose();

                this.consumerEditorControl = null;

                if (listBox2.SelectedItems.Count > 0)
                {
                    if (listBox2.SelectedItem.GetType() == typeof(DecklinkConsumer))
                    {
                        this.consumerEditorControl = new DecklinkConsumerControl(listBox2.SelectedItem as DecklinkConsumer,config.AvailableDecklinkIDs);
                        this.panelOutput.Controls.Add(consumerEditorControl);
                    }
                    else if (listBox2.SelectedItem.GetType() == typeof(ScreenConsumer))
                    {
                        this.consumerEditorControl = new ScreenConsumerControl(listBox2.SelectedItem as ScreenConsumer);
                        this.panelOutput.Controls.Add(consumerEditorControl);
                    }
                    else if (listBox2.SelectedItem.GetType() == typeof(BluefishConsumer))
                    {
                        this.consumerEditorControl = new BluefishConsumerControl(listBox2.SelectedItem as BluefishConsumer,config.AvailableBluefishIDs);
                        this.panelOutput.Controls.Add(consumerEditorControl);
                    }
                    else if (listBox2.SelectedItem.GetType() == typeof(BlockingDecklinkConsumer))
                    {
                        this.consumerEditorControl = new BlockingDecklinkConsumerControl(listBox2.SelectedItem as BlockingDecklinkConsumer, config.AvailableDecklinkIDs);
                        this.panelOutput.Controls.Add(consumerEditorControl);
                    }
                    else if (listBox2.SelectedItem.GetType() == typeof(NewTekIVGAConsumer))
                    {
                        this.consumerEditorControl = new NewTekIVGAConsumerControl(listBox2.SelectedItem as NewTekIVGAConsumer);
                        this.panelOutput.Controls.Add(consumerEditorControl);
                    }
                }
            }
            lastConsumer = (AbstractConsumer)listBox2.SelectedItem;
        }

        private void Updatechannel()
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                this.comboBox1.Enabled = true;
                this.comboBox5.Enabled = true;
                this.listBox2.Enabled = true;
                this.button4.Enabled = true;
                this.button5.Enabled = true;
                this.button7.Enabled = true;
                this.button1.Enabled = true;
                this.button2.Enabled = true;
                this.button15.Enabled = true;
                this.button16.Enabled = true;
                ignoreEvents = true;
                this.checkBox1.Checked = false;
                ignoreEvents = false;
                this.listBox2.DataSource = getConsumerList();
                this.comboBox1.SelectedItem = ((Channel)listBox1.SelectedItem).VideoMode;
                this.comboBox5.SelectedItem = ((Channel)listBox1.SelectedItem).ChannelLayout;
                this.checkBox6.Checked = ((Channel)listBox1.SelectedItem).StraightAlphaOutput;
            }
            else
            {
                this.comboBox1.Enabled = false;
                this.comboBox5.Enabled = false;
                this.listBox2.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button7.Enabled = false;
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button15.Enabled = false;
                this.button16.Enabled = false;
                this.checkBox1.Checked = false;
                this.listBox2.DataSource = null;
                this.comboBox1.SelectedItem = null;
                this.checkBox6.Checked = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.config.Channels.AddNew();
            this.Updatechannel();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Updatechannel();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            (listBox2.DataSource as BindingList<AbstractConsumer>).Add(new DecklinkConsumer(config.AvailableDecklinkIDs));

            RefreshConsumerPanel();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            (listBox2.DataSource as BindingList<AbstractConsumer>).Add(new BlockingDecklinkConsumer(config.AvailableDecklinkIDs));

            RefreshConsumerPanel();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            (listBox2.DataSource as BindingList<AbstractConsumer>).Add(new NewTekIVGAConsumer());

            RefreshConsumerPanel();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            (listBox2.DataSource as BindingList<AbstractConsumer>).Add(new ScreenConsumer());
            this.RefreshConsumerPanel();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)            
                (listBox1.SelectedItem as Channel).VideoMode = comboBox1.SelectedItem.ToString();            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)            
                this.config.Channels.Remove((Channel)listBox1.SelectedItem);
            
            this.Updatechannel();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count > 0)            
                getConsumerList().Remove(listBox2.SelectedItem as AbstractConsumer);
            
            this.RefreshConsumerPanel();
        }

        private BindingList<AbstractConsumer> getConsumerList()
        {
            if (checkBox1.Checked)
            {
                return ((listBox1.SelectedItem as Channel).Consumers[0] as SynchronizingConsumer).Consumers;
            }
            else
            {
                var consumers = (listBox1.SelectedItem as Channel).Consumers;

                if (consumers.Count > 0 && consumers[0] is SynchronizingConsumer)
                {
                    ignoreEvents = true;
                    checkBox1.Checked = true;
                    ignoreEvents = false;

                    return getConsumerList();
                }

                return consumers;
            }
        }

        private void showXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Unfocus current control, so that data binding update is performed.
            this.tabControl.SelectedTab.Focus();
            this.SerializeConfig();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RefreshConsumerPanel();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CheckForSave())
                e.Cancel = true;

            StopServer();
        }

        private bool CheckForSave()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CheckForSaveCallback(CheckForSave));
            }
            else
            {
                //var res = MessageBox.Show("Do you want to save this configuration before exiting?", "CasparCG Frontend", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                //f (res == System.Windows.Forms.DialogResult.Yes || res == System.Windows.Forms.DialogResult.OK)
                SerializeConfig();
                //else if(res == System.Windows.Forms.DialogResult.No)           
                //else if (res == System.Windows.Forms.DialogResult.Cancel)
                //    return true;
            }

            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (listBox2.DataSource as BindingList<AbstractConsumer>).Add(new SystemAudioConsumer());
            RefreshConsumerPanel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (listBox2.DataSource as BindingList<AbstractConsumer>).Add(new BluefishConsumer(config.AvailableBluefishIDs));
            RefreshConsumerPanel();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            setTextboxFilepath(datapathTextBox);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            setTextboxFilepath(logpathTextBox);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            setTextboxFilepath(mediapathTextBox);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            setTextboxFilepath(templatepathTextBox);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            setTextboxFilepath(thumbnailspathTextBox);
        }

        private void setTextboxFilepath(TextBox control)
        {
            using (var fd = new FolderBrowserDialog())
            {
                if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var p = fd.SelectedPath;
                    control.Text = fd.SelectedPath + (p.EndsWith("\\") ? "" : "\\");
                }
            }
        }

        private void buttonPaths_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedTab = this.tabPagePaths;
        }

        private void buttonChannels_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedTab = this.tabPageChannels;
        }

        private void buttonAdvanced_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedTab = this.tabPageAdvanced;
        }

        private void buttonStatus_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedTab = this.tabPageStatus;
        }

        private void buttonConsole_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedTab = this.tabPageConsole;
            this.textBoxCommand.Focus();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            if (CheckForSave())
                return;

            StopServer();
            UpdateStatus(false);
            this.textBoxLog.Clear();

            StartServer();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (CheckForSave())
                return;
            
            this.textBoxLog.Clear();

            StartServer();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            StopServer();
            UpdateStatus(false);
        }

        private void buttonDiag_Click(object sender, EventArgs e)
        {
            this.process.StandardInput.Write("DIAG\r\n");
        }

        private void buttonChannelGrid_Click(object sender, EventArgs e)
        {
            this.process.StandardInput.Write("CHANNEL_GRID\r\n");
        }

        private void ExecuteCommand()
        {
            try
            {
                this.process.StandardInput.Write(string.Format("{0}\r\n", this.textBoxCommand.Text));
            }
            catch (Exception ex) { }
        }

        private void textBoxLog_Enter(object sender, EventArgs e)
        {
            this.textBoxCommand.Focus();
        }

        private void textBoxCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (!this.textBoxCommand.Text.Equals("exit") && !this.textBoxCommand.Text.Equals("q") && !this.textBoxCommand.Text.Equals("quit") && !this.textBoxCommand.Text.Equals("bye"))
                    ExecuteCommand();

                this.textBoxCommand.Clear();
            }
        }

        private void buttonThumbnails_Click(object sender, EventArgs e)
        {
            this.process.StandardInput.Write("THUMBNAIL GENERATE_ALL\r\n");
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedItem != null)
                (listBox1.SelectedItem as Channel).ChannelLayout = comboBox5.SelectedItem.ToString();
        }

        private void buttonAddOscClient_Click(object sender, EventArgs e)
        {
            OscClientDialog dialog = new OscClientDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(dialog.GetAddress()) && dialog.GetPort() > 0)
                    this.config.Osc.PredefinedClients.Add(new PredefinedClient() { Address = dialog.GetAddress(), Port = dialog.GetPort() });
            }
        }

        private void buttonRemoveOscClient_Click(object sender, EventArgs e)
        {
            if (listBox4.SelectedItems.Count > 0)
                this.config.Osc.PredefinedClients.Remove((PredefinedClient)listBox4.SelectedItem);
        }

        private void listBox4_Click(object sender, EventArgs e)
        {
            if (listBox4.SelectedItems.Count > 0)
            {
                OscClientDialog dialog = new OscClientDialog();
                dialog.SetOscClient(((PredefinedClient)listBox4.SelectedItem).Address, ((PredefinedClient)listBox4.SelectedItem).Port);
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (!string.IsNullOrEmpty(dialog.GetAddress()) && dialog.GetPort() > 0)
                    {
                        ((PredefinedClient)listBox4.SelectedItem).Address = dialog.GetAddress();
                        ((PredefinedClient)listBox4.SelectedItem).Port = dialog.GetPort();
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ignoreEvents)
                return;

            BindingList<AbstractConsumer> consumers;
            if (checkBox1.Checked)
            {
                consumers = (listBox1.SelectedItem as Channel).Consumers;
                SynchronizingConsumer synchronizing = new SynchronizingConsumer();

                foreach (AbstractConsumer consumer in consumers)
                    synchronizing.Consumers.Add(consumer);

                consumers.Clear();
                consumers.Add(synchronizing);
            }
            else
            {
                consumers = ((listBox1.SelectedItem as Channel).Consumers[0] as SynchronizingConsumer).Consumers;
                var destination = (listBox1.SelectedItem as Channel).Consumers;

                foreach (AbstractConsumer consumer in consumers)
                    destination.Add(consumer);

                destination.RemoveAt(0);
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
                (listBox1.SelectedItem as Channel).StraightAlphaOutput = checkBox6.Checked;

            checkStraightAlphaInconsistency();
        }

        private void checkStraightAlphaInconsistency()
        {
            labelStraightAlphaNote.Visible = checkBox6.Checked && !config.Mixer.StraightAlpha;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControl.SelectedTab == this.tabPageChannels)
                checkStraightAlphaInconsistency();
        }
    }
}
