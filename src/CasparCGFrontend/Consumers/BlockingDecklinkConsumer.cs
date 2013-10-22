using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Xml.Serialization;


namespace CasparCGFrontend
{
    public class BlockingDecklinkConsumer : AbstractConsumer, INotifyPropertyChanged
    {
        public BlockingDecklinkConsumer()
        {
        }

        public BlockingDecklinkConsumer(List<string> IDs)
        {
            this.device = IDs.First();
        }

        private String device ="1";
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

        private string keyer = "external";
        [XmlElement(ElementName = "keyer")]
        public string Keyer
        {
            get { return this.keyer; }
            set { this.keyer = value; NotifyChanged("Keyer"); }
        }
        public bool ShouldSerializeKeyer()
        {
            return keyer != "external";
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

        private Boolean customAllocator = true;
        [XmlElement(ElementName = "custom-allocator")]
        public Boolean CustomAllocator
        {
            get { return this.customAllocator; }
            set { this.customAllocator = value; NotifyChanged("CustomAllocator"); }
        }
        public bool ShouldSerializeCustomAllocator()
        {
            return !customAllocator;
        }

        public override String ToString()
        {
            return "Sync Decklink";
        }

        public override event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void NotifyChanged(String info)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(info));            
        }
    }
}
