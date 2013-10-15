using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CasparCGFrontend
{
    public partial class NewTekIVGAConsumerControl : ConsumerControlBase
    {
        public NewTekIVGAConsumerControl(NewTekIVGAConsumer consumer)
        {
            InitializeComponent();
            newTekConsumerBindingSource.DataSource = consumer;
        }

        ~NewTekIVGAConsumerControl()
        {
            newTekConsumerBindingSource.Dispose();
        }
    }
}
