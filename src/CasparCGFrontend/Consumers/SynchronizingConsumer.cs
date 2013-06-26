using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CasparCGFrontend
{
    public class SynchronizingConsumer : AbstractConsumer, INotifyPropertyChanged
    {
        public SynchronizingConsumer()
        {
        }

        private BindingList<AbstractConsumer> consumers = new BindingList<AbstractConsumer>();
        [XmlElementAttribute("decklink", Type = typeof(DecklinkConsumer))]
        [XmlElementAttribute("blocking-decklink", Type = typeof(BlockingDecklinkConsumer))]
        [XmlElementAttribute("screen", Type = typeof(ScreenConsumer))]
        [XmlElementAttribute("system-audio", Type = typeof(SystemAudioConsumer))]
        [XmlElementAttribute("bluefish", Type = typeof(BluefishConsumer))]
        public BindingList<AbstractConsumer> Consumers
        {
            get { return this.consumers; }
            set { this.consumers = value; NotifyChanged("Consumers"); }
        }

        public override string ToString()
        {
            return "Synchronizing";
        }

        public override event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void NotifyChanged(String info)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(info));
        }
    }
}
