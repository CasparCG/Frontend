namespace CasparCGFrontend
{
    partial class DecklinkConsumerControl
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
            System.Windows.Forms.Label bufferdepthLabel;
            System.Windows.Forms.Label deviceLabel;
            System.Windows.Forms.Label embeddedaudioLabel;
            System.Windows.Forms.Label keyLabel;
            System.Windows.Forms.Label keyonlyLabel;
            System.Windows.Forms.Label latencyLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.decklinkConsumerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.embeddedaudioCheckBox = new System.Windows.Forms.CheckBox();
            this.keyonlyCheckBox = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.availableIDsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            bufferdepthLabel = new System.Windows.Forms.Label();
            deviceLabel = new System.Windows.Forms.Label();
            embeddedaudioLabel = new System.Windows.Forms.Label();
            keyLabel = new System.Windows.Forms.Label();
            keyonlyLabel = new System.Windows.Forms.Label();
            latencyLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.decklinkConsumerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableIDsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bufferdepthLabel
            // 
            bufferdepthLabel.AutoSize = true;
            bufferdepthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            bufferdepthLabel.Location = new System.Drawing.Point(25, 10);
            bufferdepthLabel.Name = "bufferdepthLabel";
            bufferdepthLabel.Size = new System.Drawing.Size(74, 13);
            bufferdepthLabel.TabIndex = 1;
            bufferdepthLabel.Text = "Buffer Depth";
            // 
            // deviceLabel
            // 
            deviceLabel.AutoSize = true;
            deviceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            deviceLabel.Location = new System.Drawing.Point(49, 38);
            deviceLabel.Name = "deviceLabel";
            deviceLabel.Size = new System.Drawing.Size(50, 13);
            deviceLabel.TabIndex = 3;
            deviceLabel.Text = "Device #";
            // 
            // embeddedaudioLabel
            // 
            embeddedaudioLabel.AutoSize = true;
            embeddedaudioLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            embeddedaudioLabel.Location = new System.Drawing.Point(3, 66);
            embeddedaudioLabel.Name = "embeddedaudioLabel";
            embeddedaudioLabel.Size = new System.Drawing.Size(96, 13);
            embeddedaudioLabel.TabIndex = 5;
            embeddedaudioLabel.Text = "Embedded Audio";
            // 
            // keyLabel
            // 
            keyLabel.AutoSize = true;
            keyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            keyLabel.Location = new System.Drawing.Point(65, 94);
            keyLabel.Name = "keyLabel";
            keyLabel.Size = new System.Drawing.Size(34, 13);
            keyLabel.TabIndex = 7;
            keyLabel.Text = "Keyer";
            // 
            // keyonlyLabel
            // 
            keyonlyLabel.AutoSize = true;
            keyonlyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            keyonlyLabel.Location = new System.Drawing.Point(48, 122);
            keyonlyLabel.Name = "keyonlyLabel";
            keyonlyLabel.Size = new System.Drawing.Size(51, 13);
            keyonlyLabel.TabIndex = 9;
            keyonlyLabel.Text = "Key Only";
            // 
            // latencyLabel
            // 
            latencyLabel.AutoSize = true;
            latencyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            latencyLabel.Location = new System.Drawing.Point(54, 148);
            latencyLabel.Name = "latencyLabel";
            latencyLabel.Size = new System.Drawing.Size(45, 13);
            latencyLabel.TabIndex = 11;
            latencyLabel.Text = "Latency";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            label1.Location = new System.Drawing.Point(12, 176);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(87, 13);
            label1.TabIndex = 17;
            label1.Text = "Channel Layout";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            label2.Location = new System.Drawing.Point(4, 204);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(95, 13);
            label2.TabIndex = 20;
            label2.Text = "Custom Allocator";
            // 
            // decklinkConsumerBindingSource
            // 
            this.decklinkConsumerBindingSource.AllowNew = false;
            this.decklinkConsumerBindingSource.DataSource = typeof(CasparCGFrontend.DecklinkConsumer);
            // 
            // embeddedaudioCheckBox
            // 
            this.embeddedaudioCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.decklinkConsumerBindingSource, "EmbeddedAudio", true));
            this.embeddedaudioCheckBox.Location = new System.Drawing.Point(105, 61);
            this.embeddedaudioCheckBox.Name = "embeddedaudioCheckBox";
            this.embeddedaudioCheckBox.Size = new System.Drawing.Size(104, 24);
            this.embeddedaudioCheckBox.TabIndex = 6;
            this.embeddedaudioCheckBox.UseVisualStyleBackColor = true;
            // 
            // keyonlyCheckBox
            // 
            this.keyonlyCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.decklinkConsumerBindingSource, "KeyOnly", true));
            this.keyonlyCheckBox.Location = new System.Drawing.Point(105, 117);
            this.keyonlyCheckBox.Name = "keyonlyCheckBox";
            this.keyonlyCheckBox.Size = new System.Drawing.Size(104, 24);
            this.keyonlyCheckBox.TabIndex = 10;
            this.keyonlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.decklinkConsumerBindingSource, "Keyer", true));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "external",
            "internal",
            "default"});
            this.comboBox1.Location = new System.Drawing.Point(105, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.decklinkConsumerBindingSource, "Latency", true));
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "normal",
            "low",
            "default"});
            this.comboBox2.Location = new System.Drawing.Point(105, 145);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 14;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.decklinkConsumerBindingSource, "BufferDepth", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox3.Location = new System.Drawing.Point(105, 7);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 15;
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.decklinkConsumerBindingSource, "Device", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(105, 35);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 16;
            // 
            // availableIDsBindingSource
            // 
            this.availableIDsBindingSource.DataMember = "AvailableIDs";
            // 
            // comboBox5
            // 
            this.comboBox5.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.decklinkConsumerBindingSource, "ChannelLayout", true));
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
            this.comboBox5.Location = new System.Drawing.Point(105, 173);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 18;
            // 
            // checkBox1
            // 
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.decklinkConsumerBindingSource, "CustomAllocator", true));
            this.checkBox1.Location = new System.Drawing.Point(105, 199);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 24);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // DecklinkConsumerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(label2);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(label1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(bufferdepthLabel);
            this.Controls.Add(deviceLabel);
            this.Controls.Add(embeddedaudioLabel);
            this.Controls.Add(this.embeddedaudioCheckBox);
            this.Controls.Add(keyLabel);
            this.Controls.Add(keyonlyLabel);
            this.Controls.Add(this.keyonlyCheckBox);
            this.Controls.Add(latencyLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DecklinkConsumerControl";
            ((System.ComponentModel.ISupportInitialize)(this.decklinkConsumerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableIDsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource decklinkConsumerBindingSource;
        private System.Windows.Forms.CheckBox embeddedaudioCheckBox;
        private System.Windows.Forms.CheckBox keyonlyCheckBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource availableIDsBindingSource;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
