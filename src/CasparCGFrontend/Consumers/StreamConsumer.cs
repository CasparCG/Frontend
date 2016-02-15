using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CasparCGFrontend
{
    public class StreamConsumer : AbstractConsumer, INotifyPropertyChanged
    {
        public StreamConsumer()
        {
        }

        public override string ToString()
        {
            return "Stream";
        }

        private string path = "";
        [XmlElement(ElementName = "path")]
        public string Path
        {
            get { return this.path; }
            set { this.path = value; NotifyChanged("Path"); }
        }
        public bool ShouldSerializePath()
        {
            return true;
        }

        private string args = "";
        [XmlElement(ElementName = "args")]
        public string Args
        {
            get { return this.args; }
            set { this.args = value; NotifyChanged("Args"); }
        }
        public bool ShouldSerializeArgs()
        {
            return true;
        }

        public override event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void NotifyChanged(String info)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(info));
        }
    }
}
