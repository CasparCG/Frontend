using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CasparCGFrontend
{
    public class Flash : INotifyPropertyChanged
    {
        public Flash()
        {
        }

        private string bufferDepth = "auto";
        [XmlElement(ElementName = "buffer-depth")]
        public string BufferDepth
        {
            get { return this.bufferDepth; }
            set { this.bufferDepth = value; NotifyChanged("BufferDepth"); }
        }

        public bool IsOnlyDefaultValues()
        {
            return bufferDepth == "auto";
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void NotifyChanged(String info)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(info));
        }
    }
}
