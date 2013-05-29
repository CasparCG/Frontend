using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Xml.Serialization;


namespace CasparCGFrontend
{
    public class PredefinedClient : INotifyPropertyChanged
    {
        public PredefinedClient() { }

        private string address = "127.0.0.1";
        [XmlElement(ElementName = "address")]
        public string Address
        {
            get { return this.address; }
            set { this.address = value; NotifyChanged("Address"); }
        }

        private int port = 6250;
        [XmlElement(ElementName = "port")]
        public int Port
        {
            get { return this.port; }
            set { this.port = value; NotifyChanged("Port"); }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void NotifyChanged(String info)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(info));
        }
    }
}
