using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CasparCGFrontend
{
    public class Audio : INotifyPropertyChanged
    {
        public Audio() { }

        private BindingList<ChannelLayout> channelLayouts = new BindingList<ChannelLayout>();
        [XmlArray("channel-layouts")]
        [XmlArrayItem("channel-layout", Type = typeof(ChannelLayout))]
        public BindingList<ChannelLayout> ChannelLayouts
        {
            get { return this.channelLayouts; }
            set { this.channelLayouts = value; NotifyChanged("ChannelLayouts"); }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void NotifyChanged(String info)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(info));
        }
    }
}
