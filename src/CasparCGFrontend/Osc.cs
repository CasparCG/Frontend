using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CasparCGFrontend
{
    public class Osc : INotifyPropertyChanged
    {
        public Osc()
        {
        }

        private string defaultPort = "6250";
        [XmlElement(ElementName = "default-port")]
        public string DefaultPort
        {
            get { return this.defaultPort; }
            set { this.defaultPort = value; NotifyChanged("DefaultPort"); }
        }
        public bool ShouldSerializeDefaultPort()
        {
            return defaultPort != "6250";
        }

        private BindingList<PredefinedClient> predefinedClients = new BindingList<PredefinedClient>();
        [XmlArray("predefined-clients")]
        [XmlArrayItem("predefined-client", Type = typeof(PredefinedClient))]
        public BindingList<PredefinedClient> PredefinedClients
        {
            get { return this.predefinedClients; }
            set { this.predefinedClients = value; NotifyChanged("PredefinedClients"); }
        }
        public bool ShouldSerializePredefinedClients()
        {
            return predefinedClients.Count != 0;
        }

        public bool IsOnlyDefaultValues()
        {
            return !ShouldSerializeDefaultPort() && !ShouldSerializePredefinedClients();
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void NotifyChanged(String info)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(info));
        }
    }
}
