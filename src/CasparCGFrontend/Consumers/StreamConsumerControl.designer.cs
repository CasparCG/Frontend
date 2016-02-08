namespace CasparCGFrontend
{
    partial class StreamConsumerControl
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.textArgs = new System.Windows.Forms.TextBox();
            this.streamConsumerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textPath = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.streamConsumerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textArgs
            // 
            this.textArgs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textArgs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.textArgs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textArgs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.streamConsumerBindingSource, "Args", true));
            this.textArgs.ForeColor = System.Drawing.SystemColors.Window;
            this.textArgs.Location = new System.Drawing.Point(54, 33);
            this.textArgs.Name = "textArgs";
            this.textArgs.Size = new System.Drawing.Size(192, 26);
            this.textArgs.TabIndex = 21;
            // 
            // streamConsumerBindingSource
            // 
            this.streamConsumerBindingSource.AllowNew = false;
            this.streamConsumerBindingSource.DataSource = typeof(CasparCGFrontend.StreamConsumer);
            // 
            // textPath
            // 
            this.textPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.textPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.streamConsumerBindingSource, "Path", true));
            this.textPath.ForeColor = System.Drawing.SystemColors.Window;
            this.textPath.Location = new System.Drawing.Point(54, 5);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(192, 26);
            this.textPath.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            label2.Location = new System.Drawing.Point(18, 37);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(37, 19);
            label2.TabIndex = 19;
            label2.Text = "Args";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            label1.Location = new System.Drawing.Point(18, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(37, 19);
            label1.TabIndex = 17;
            label1.Text = "Path";
            // 
            // StreamConsumerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.textArgs);
            this.Controls.Add(this.textPath);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "StreamConsumerControl";
            this.Size = new System.Drawing.Size(464, 431);
            ((System.ComponentModel.ISupportInitialize)(this.streamConsumerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource streamConsumerBindingSource;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.TextBox textArgs;
    }
}
