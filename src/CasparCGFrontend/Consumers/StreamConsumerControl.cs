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
    public partial class StreamConsumerControl : ConsumerControlBase
    {
        public StreamConsumerControl(StreamConsumer consumer)
        {
            InitializeComponent();
            streamConsumerBindingSource.DataSource = consumer;
        }

        ~StreamConsumerControl()
        {
            streamConsumerBindingSource.Dispose();
        }
    }
}
