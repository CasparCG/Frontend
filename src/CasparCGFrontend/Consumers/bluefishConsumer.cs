using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Xml.Serialization;


namespace CasparCGFrontend
{
    public class BluefishConsumer : AbstractConsumer, INotifyPropertyChanged
    {
        public BluefishConsumer()
        {
        }

        public BluefishConsumer(List<string> IDs)
        {
            this.device = IDs.First();
        }

        private String device = "1";
        [XmlElement(ElementName = "device")]
        public String Device
        {
            get { return this.device; }
            set { this.device = value; NotifyChanged("Device"); }
        }

        private Boolean embeddedaudio = false;
        [XmlElement(ElementName = "embedded-audio")]
        public Boolean EmbeddedAudio
        {
            get { return this.embeddedaudio; }
            set { this.embeddedaudio = value; NotifyChanged("EmbeddedAudio"); }
        }
        public bool ShouldSerializeEmbeddedAudio()
        {
            return embeddedaudio;
        }

        private string channelLayout = "stereo";
        [XmlElement(ElementName = "channel-layout")]
        public string ChannelLayout
        {
            get { return this.channelLayout; }
            set { this.channelLayout = value; NotifyChanged("ChannelLayout"); }
        }
        public bool ShouldSerializeChannelLayout()
        {
            return channelLayout != "stereo";
        }

        private Boolean keyonly = false;
        [XmlElement(ElementName = "key-only")]
        public Boolean KeyOnly
        {
            get { return this.keyonly; }
            set { this.keyonly = value; NotifyChanged("KeyOnly"); }
        }
        public bool ShouldSerializeKeyOnly()
        {
            return keyonly;
        }

        public override string ToString()
        {
            return "Bluefish";
        }

        public override event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void NotifyChanged(String info)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(info));
        }
    }
}
