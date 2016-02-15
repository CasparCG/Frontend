using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CasparCGFrontend
{
    [XmlInclude(typeof(DecklinkConsumer))]
    [XmlInclude(typeof(ScreenConsumer))]
    [XmlInclude(typeof(SystemAudioConsumer))]
    [XmlInclude(typeof(BluefishConsumer))]
    [XmlInclude(typeof(NewTekIVGAConsumer))]
    [XmlInclude(typeof(StreamConsumer))]
    public abstract class AbstractConsumer : INotifyPropertyChanged
    {
        public virtual event PropertyChangedEventHandler PropertyChanged = delegate{};

        private void NotifyChanged(String info)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(info));            
        }
    }
}
