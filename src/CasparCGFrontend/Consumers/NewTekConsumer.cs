using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CasparCGFrontend
{
    public class NewTekConsumer : AbstractConsumer, INotifyPropertyChanged
    {
        public NewTekConsumer()
        {
        }

        public override string ToString()
        {
            return "NewTek";
        }

        private string channelLayout = "stereo";
        [XmlElement(ElementName = "channel-layout")]
        public string ChannelLayout
        {
            get { return this.channelLayout; }
            set { this.channelLayout = value; NotifyChanged("ChannelLayout"); }
        }

        public override event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void NotifyChanged(String info)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(info));
        }
    }
}
