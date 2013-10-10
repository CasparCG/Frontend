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
    public partial class NewTekConsumerControl : ConsumerControlBase
    {
        public NewTekConsumerControl(NewTekConsumer consumer)
        {
            InitializeComponent();
            newTekConsumerBindingSource.DataSource = consumer;
        }

        ~NewTekConsumerControl()
        {
            newTekConsumerBindingSource.Dispose();
        }
    }
}
