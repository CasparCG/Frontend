using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CasparCGFrontend
{
    public class ChannelLayout : INotifyPropertyChanged
    {
        public ChannelLayout() { }

        private string name = "mono";
        [XmlElement(ElementName = "name")]
        public string Name
        {
            get { return this.name; }
            set { this.name = value; NotifyChanged("Name"); }
        }

        private string type = "1.0";
        [XmlElement(ElementName = "type")]
        public string Type
        {
            get { return this.type; }
            set { this.type = value; NotifyChanged("Type"); }
        }

        private int numChannels = 1;
        [XmlElement(ElementName = "num-channels")]
        public int NumChannels
        {
            get { return this.numChannels; }
            set { this.numChannels = value; NotifyChanged("NumChannels"); }
        }

        private string channels = "C";
        [XmlElement(ElementName = "channels")]
        public string Channels
        {
            get { return this.channels; }
            set { this.channels = value; NotifyChanged("Channels"); }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void NotifyChanged(String info)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(info));
        }
    }
}
