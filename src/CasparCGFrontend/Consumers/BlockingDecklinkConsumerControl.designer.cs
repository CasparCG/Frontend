namespace CasparCGFrontend
{
    partial class BlockingDecklinkConsumerControl
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
            System.Windows.Forms.Label keyLabel;
            System.Windows.Forms.Label keyonlyLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            this.decklinkConsumerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.embeddedaudioCheckBox = new System.Windows.Forms.CheckBox();
            this.keyonlyCheckBox = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.availableIDsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            deviceLabel = new System.Windows.Forms.Label();
            embeddedaudioLabel = new System.Windows.Forms.Label();
            keyLabel = new System.Windows.Forms.Label();
            keyonlyLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.decklinkConsumerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableIDsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // deviceLabel
            // 
            deviceLabel.AutoSize = true;
            deviceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            deviceLabel.Location = new System.Drawing.Point(49, 10);
            deviceLabel.Name = "deviceLabel";
            deviceLabel.Size = new System.Drawing.Size(50, 13);
            deviceLabel.TabIndex = 3;
            deviceLabel.Text = "Device #";
            // 
            // embeddedaudioLabel
            // 
            embeddedaudioLabel.AutoSize = true;
            embeddedaudioLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            embeddedaudioLabel.Location = new System.Drawing.Point(3, 38);
            embeddedaudioLabel.Name = "embeddedaudioLabel";
            embeddedaudioLabel.Size = new System.Drawing.Size(96, 13);
            embeddedaudioLabel.TabIndex = 5;
            embeddedaudioLabel.Text = "Embedded Audio";
            // 
            // keyLabel
            // 
            keyLabel.AutoSize = true;
            keyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            keyLabel.Location = new System.Drawing.Point(65, 65);
            keyLabel.Name = "keyLabel";
            keyLabel.Size = new System.Drawing.Size(34, 13);
            keyLabel.TabIndex = 7;
            keyLabel.Text = "Keyer";
            // 
            // keyonlyLabel
            // 
            keyonlyLabel.AutoSize = true;
            keyonlyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            keyonlyLabel.Location = new System.Drawing.Point(48, 94);
            keyonlyLabel.Name = "keyonlyLabel";
            keyonlyLabel.Size = new System.Drawing.Size(51, 13);
            keyonlyLabel.TabIndex = 9;
            keyonlyLabel.Text = "Key Only";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            label1.Location = new System.Drawing.Point(12, 119);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(87, 13);
            label1.TabIndex = 17;
            label1.Text = "Channel Layout";
            // 
            // decklinkConsumerBindingSource
            // 
            this.decklinkConsumerBindingSource.AllowNew = false;
            this.decklinkConsumerBindingSource.DataSource = typeof(CasparCGFrontend.DecklinkConsumer);
            // 
            // embeddedaudioCheckBox
            // 
            this.embeddedaudioCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.decklinkConsumerBindingSource, "EmbeddedAudio", true));
            this.embeddedaudioCheckBox.Location = new System.Drawing.Point(105, 33);
            this.embeddedaudioCheckBox.Name = "embeddedaudioCheckBox";
            this.embeddedaudioCheckBox.Size = new System.Drawing.Size(104, 24);
            this.embeddedaudioCheckBox.TabIndex = 6;
            this.embeddedaudioCheckBox.UseVisualStyleBackColor = true;
            // 
            // keyonlyCheckBox
            // 
            this.keyonlyCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.decklinkConsumerBindingSource, "KeyOnly", true));
            this.keyonlyCheckBox.Location = new System.Drawing.Point(105, 89);
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
            this.comboBox1.Location = new System.Drawing.Point(105, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.decklinkConsumerBindingSource, "Device", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(105, 7);
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
            this.comboBox5.Location = new System.Drawing.Point(105, 116);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 18;
            // 
            // label3
            // 
            label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            label3.Location = new System.Drawing.Point(12, 155);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(214, 31);
            label3.TabIndex = 20;
            label3.Text = "Note: this consumer is to be considered experimental";
            // 
            // BlockingDecklinkConsumerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(label3);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(label1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(deviceLabel);
            this.Controls.Add(embeddedaudioLabel);
            this.Controls.Add(this.embeddedaudioCheckBox);
            this.Controls.Add(keyLabel);
            this.Controls.Add(keyonlyLabel);
            this.Controls.Add(this.keyonlyCheckBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BlockingDecklinkConsumerControl";
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
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource availableIDsBindingSource;
        private System.Windows.Forms.ComboBox comboBox5;
    }
}
