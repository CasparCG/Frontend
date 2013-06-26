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
    public partial class BlockingDecklinkConsumerControl : ConsumerControlBase
    {
        public BlockingDecklinkConsumerControl(BlockingDecklinkConsumer consumer,List<String> availableIDs)
        {
            InitializeComponent();
            var ar = availableIDs.ToList();
            ar.Add(consumer.Device);
            ar.Sort();
            comboBox4.Items.AddRange(ar.ToArray());
            decklinkConsumerBindingSource.DataSource = consumer;
        }

        ~BlockingDecklinkConsumerControl()
        {
            decklinkConsumerBindingSource.Dispose();
        }
    }
}
