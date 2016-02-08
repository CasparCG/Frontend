using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CasparCGFrontend
{
    public class NewTekIVGAConsumer : AbstractConsumer, INotifyPropertyChanged
    {
        public NewTekIVGAConsumer()
        {
        }

        public override string ToString()
        {
            return "NewTek iVGA";
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

        private Boolean provideSync = true;
        [XmlElement(ElementName = "provide-sync")]
        public Boolean ProvideSync
        {
            get { return this.provideSync; }
            set { this.provideSync = value; NotifyChanged("ProvideSync"); }
        }
        public bool ShouldSerializeProvideSync()
        {
            return provideSync != true;
        }

        public override event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void NotifyChanged(String info)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(info));
        }
    }
}
