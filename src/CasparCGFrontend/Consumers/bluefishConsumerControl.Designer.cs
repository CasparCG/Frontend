namespace CasparCGFrontend
{
    partial class BluefishConsumerControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label deviceLabel;
            System.Windows.Forms.Label embeddedaudioLabel;
            System.Windows.Forms.Label keyonlyLabel;
            System.Windows.Forms.Label label1;
            this.bluefishConsumerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.embeddedaudioCheckBox = new System.Windows.Forms.CheckBox();
            this.keyonlyCheckBox = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            deviceLabel = new System.Windows.Forms.Label();
            embeddedaudioLabel = new System.Windows.Forms.Label();
            keyonlyLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bluefishConsumerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // deviceLabel
            // 
            deviceLabel.AutoSize = true;
            deviceLabel.BackColor = System.Drawing.Color.Transparent;
            deviceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            deviceLabel.Location = new System.Drawing.Point(47, 8);
            deviceLabel.Name = "deviceLabel";
            deviceLabel.Size = new System.Drawing.Size(50, 13);
            deviceLabel.TabIndex = 1;
            deviceLabel.Text = "Device #";
            // 
            // embeddedaudioLabel
            // 
            embeddedaudioLabel.AutoSize = true;
            embeddedaudioLabel.BackColor = System.Drawing.Color.Transparent;
            embeddedaudioLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            embeddedaudioLabel.Location = new System.Drawing.Point(1, 39);
            embeddedaudioLabel.Name = "embeddedaudioLabel";
            embeddedaudioLabel.Size = new System.Drawing.Size(96, 13);
            embeddedaudioLabel.TabIndex = 3;
            embeddedaudioLabel.Text = "Embedded Audio";
            // 
            // keyonlyLabel
            // 
            keyonlyLabel.AutoSize = true;
            keyonlyLabel.BackColor = System.Drawing.Color.Transparent;
            keyonlyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            keyonlyLabel.Location = new System.Drawing.Point(46, 70);
            keyonlyLabel.Name = "keyonlyLabel";
            keyonlyLabel.Size = new System.Drawing.Size(51, 13);
            keyonlyLabel.TabIndex = 5;
            keyonlyLabel.Text = "Key Only";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            label1.Location = new System.Drawing.Point(10, 98);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(87, 13);
            label1.TabIndex = 20;
            label1.Text = "Channel Layout";
            // 
            // bluefishConsumerBindingSource
            // 
            this.bluefishConsumerBindingSource.DataSource = typeof(CasparCGFrontend.BluefishConsumer);
            // 
            // embeddedaudioCheckBox
            // 
            this.embeddedaudioCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bluefishConsumerBindingSource, "EmbeddedAudio", true));
            this.embeddedaudioCheckBox.Location = new System.Drawing.Point(103, 34);
            this.embeddedaudioCheckBox.Name = "embeddedaudioCheckBox";
            this.embeddedaudioCheckBox.Size = new System.Drawing.Size(104, 24);
            this.embeddedaudioCheckBox.TabIndex = 4;
            this.toolTip.SetToolTip(this.embeddedaudioCheckBox, "Output audio embedded in the SDI signal. This adds another 1 frame of delay. Defa" +
        "ult is false.");
            this.embeddedaudioCheckBox.UseVisualStyleBackColor = true;
            // 
            // keyonlyCheckBox
            // 
            this.keyonlyCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bluefishConsumerBindingSource, "KeyOnly", true));
            this.keyonlyCheckBox.Location = new System.Drawing.Point(103, 65);
            this.keyonlyCheckBox.Name = "keyonlyCheckBox";
            this.keyonlyCheckBox.Size = new System.Drawing.Size(104, 24);
            this.keyonlyCheckBox.TabIndex = 6;
            this.toolTip.SetToolTip(this.keyonlyCheckBox, "Output only the key signal for the channel. Default is false.");
            this.keyonlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bluefishConsumerBindingSource, "Device", true));
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(103, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 19;
            this.toolTip.SetToolTip(this.comboBox2, "If you have multiple cards or cards supporting more than one output you can selec" +
        "t the Device number here. Be careful to select a different device for all Bluefi" +
        "sh channels.");
            // 
            // comboBox5
            // 
            this.comboBox5.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bluefishConsumerBindingSource, "ChannelLayout", true));
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "mono",
            "stereo",
            "dts",
            "dolbye",
            "dolbydigital",
            "smpte",
            "passthru"});
            this.comboBox5.Location = new System.Drawing.Point(103, 95);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 21;
            this.toolTip.SetToolTip(this.comboBox5, "This is the audio channels configuration. Passthru will pass 16 channels of audio" +
        " withour modifying it. More information: http://casparcg.com/wiki/Content_/_Medi" +
        "a#Audio Default is Stereo.");
            // 
            // BluefishConsumerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(deviceLabel);
            this.Controls.Add(embeddedaudioLabel);
            this.Controls.Add(this.embeddedaudioCheckBox);
            this.Controls.Add(keyonlyLabel);
            this.Controls.Add(this.keyonlyCheckBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BluefishConsumerControl";
            ((System.ComponentModel.ISupportInitialize)(this.bluefishConsumerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bluefishConsumerBindingSource;
        private System.Windows.Forms.CheckBox embeddedaudioCheckBox;
        private System.Windows.Forms.CheckBox keyonlyCheckBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ToolTip toolTip;

    }
}
