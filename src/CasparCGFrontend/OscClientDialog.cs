using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CasparCGFrontend
{
    public partial class OscClientDialog : Form
    {
        public OscClientDialog()
        {
            InitializeComponent();

            this.Text = "Add " + this.Text;
        }

        public void SetOscClient(string address, int port)
        {
            this.Text = "Edit " + this.Text;

            this.textBoxAddress.Text = address;
            this.textBoxPort.Text = port.ToString();
        }

        public string GetAddress()
        {
            return this.textBoxAddress.Text;
        }

        public int GetPort()
        {
            return Convert.ToInt32(this.textBoxPort.Text);
        }
    }
}
