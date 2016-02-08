namespace CasparCGFrontend
{
    partial class NewTekIVGAConsumerControl
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.newTekConsumerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.checkProvideSync = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.newTekConsumerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            label1.Location = new System.Drawing.Point(12, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(105, 19);
            label1.TabIndex = 17;
            label1.Text = "Channel Layout";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            label2.Location = new System.Drawing.Point(30, 37);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(87, 19);
            label2.TabIndex = 19;
            label2.Text = "Provide Sync";
            // 
            // newTekConsumerBindingSource
            // 
            this.newTekConsumerBindingSource.AllowNew = false;
            this.newTekConsumerBindingSource.DataSource = typeof(CasparCGFrontend.DecklinkConsumer);
            // 
            // comboBox5
            // 
            this.comboBox5.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.newTekConsumerBindingSource, "ChannelLayout", true));
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
            this.comboBox5.Location = new System.Drawing.Point(105, 7);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 27);
            this.comboBox5.TabIndex = 18;
            this.toolTip.SetToolTip(this.comboBox5, "This is the audio channels configuration. Passthru will pass 16 channels of audio" +
                    " withour modifying it. More information: http://casparcg.com/wiki/Content_/_Medi" +
                    "a#Audio Default is Stereo.");
            // 
            // checkProvideSync
            // 
            this.checkProvideSync.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.newTekConsumerBindingSource, "ProvideSync", true));
            this.checkProvideSync.Location = new System.Drawing.Point(105, 35);
            this.checkProvideSync.Name = "checkProvideSync";
            this.checkProvideSync.Size = new System.Drawing.Size(104, 24);
            this.checkProvideSync.TabIndex = 4;
            this.toolTip.SetToolTip(this.checkProvideSync, "Whether to provide sync to NewTek IVGA.");
            this.checkProvideSync.UseVisualStyleBackColor = true;
            // 
            // NewTekIVGAConsumerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.checkProvideSync);
            this.Controls.Add(label2);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "NewTekIVGAConsumerControl";
            this.Size = new System.Drawing.Size(464, 431);
            ((System.ComponentModel.ISupportInitialize)(this.newTekConsumerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource newTekConsumerBindingSource;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox checkProvideSync;
    }
}
