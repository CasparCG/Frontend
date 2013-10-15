using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CasparCGFrontend
{
    public class configuration : INotifyPropertyChanged
    {
        public configuration()
        {
            Channels.ListChanged +=new ListChangedEventHandler(Channels_ListChanged);
        }

        private void Channels_ListChanged(object sender, ListChangedEventArgs e)
        {
            NotifyChanged("Channels");
        }
        
        private Paths paths = new Paths();
        [XmlElement(ElementName = "paths")]
        public Paths Paths
        {
            get { return this.paths; }
            set { this.paths = value; NotifyChanged("Paths"); }
        }

        private string logLevel = "debug";
        [XmlElement(ElementName = "log-level")]
        public string LogLevel
        {
            get { return this.logLevel; }
            set { this.logLevel = value; NotifyChanged("LogLevel"); }
        }

        private Boolean channelGrid = false;
        [XmlElement(ElementName = "channel-grid")]
        public Boolean ChannelGrid
        {
            get { return this.channelGrid; }
            set { this.channelGrid = value; NotifyChanged("ChannelGrid"); }
        }

        private Mixer mixer = new Mixer();
        [XmlElement(ElementName = "mixer")]
        public Mixer Mixer
        {
            get { return this.mixer; }
            set { this.mixer = value; NotifyChanged("Mixer"); }
        }

        /*
        private Boolean forceDeinterlace = true;
        [XmlElement(ElementName = "force-deinterlace")]
        public Boolean ForceDeinterlace
        {
            get { return this.forceDeinterlace; }
            set { this.forceDeinterlace = value; NotifyChanged("ForceDeinterlace"); }
        }
        */

        private Boolean autoTranscode = true;
        [XmlElement(ElementName = "auto-transcode")]
        public Boolean AutoTranscode
        {
            get { return this.autoTranscode; }
            set { this.autoTranscode = value; NotifyChanged("AutoTranscode"); }
        }

        /*
        private String accelerator = "auto";
        [XmlElement(ElementName = "accelerator")]
        public String Accelerator
        {
            get { return this.accelerator; }
            set { this.accelerator = value; NotifyChanged("Accelerator"); }
        }
        */

        private Flash flash = new Flash();
        [XmlElement(ElementName = "flash")]
        public Flash Flash
        {
            get { return this.flash; }
            set { this.flash = value; NotifyChanged("Flash"); }
        }

        private Thumbnails thumbnails = new Thumbnails();
        [XmlElement(ElementName = "thumbnails")]
        public Thumbnails Thumbnails
        {
            get { return this.thumbnails; }
            set { this.thumbnails = value; NotifyChanged("Thumbnail"); }
        }

        private BindingList<Channel> channels = new BindingList<Channel>();
        [XmlArray("channels")]
        [XmlArrayItem("channel", Type = typeof(Channel))]
        public BindingList<Channel> Channels
        {
            get { return this.channels; }
            set { this.channels = value; NotifyChanged("Channels"); }
        }

        private Audio audio = new Audio();
        [XmlElement(ElementName = "audio")]
        public Audio Audio
        {
            get { return this.audio; }
            set { this.audio = value; NotifyChanged("Audio"); }
        }

        private Osc osc = new Osc();
        [XmlElement(ElementName = "osc")]
        public Osc Osc
        {
            get { return this.osc; }
            set { this.osc = value; NotifyChanged("Osc"); }
        }

        private List<String> defaultDecklinkIDs = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        [XmlIgnore]
        public List<String> AvailableDecklinkIDs
        {
            get
            {
                List<String> availableDecklinkIDs = new List<String>();
                defaultDecklinkIDs.ForEach(id => availableDecklinkIDs.Add(id));
                foreach (Channel ch in this.Channels)
                {
                    BindingList<AbstractConsumer> consumers = ch.Consumers;

                    if (consumers.Count > 0 && consumers[0] is SynchronizingConsumer)
                        consumers = (consumers[0] as SynchronizingConsumer).Consumers;

                    foreach (AbstractConsumer cs in consumers)
                    {
                        if (cs.GetType() == typeof(DecklinkConsumer))
                        {
                            availableDecklinkIDs.Remove(((DecklinkConsumer)cs).Device);
                        }
                        else if (cs.GetType() == typeof(BlockingDecklinkConsumer))
                        {
                            availableDecklinkIDs.Remove(((BlockingDecklinkConsumer)cs).Device);
                        }
                    }
                }
                return availableDecklinkIDs;
            }
        }

        private List<String> defaultBluefishIDs = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        [XmlIgnore]
        public List<String> AvailableBluefishIDs
        {
            get
            {
                List<String> availableBluefishIDs = new List<String>();
                defaultBluefishIDs.ForEach(id => availableBluefishIDs.Add(id));
                foreach (Channel ch in this.Channels)
                {
                    BindingList<AbstractConsumer> consumers = ch.Consumers;

                    if (consumers.Count > 0 && consumers[0] is SynchronizingConsumer)
                        consumers = (consumers[0] as SynchronizingConsumer).Consumers;

                    foreach (AbstractConsumer cs in consumers)
                    {
                        if (cs.GetType() == typeof(BluefishConsumer))
                        {
                            availableBluefishIDs.Remove(((BluefishConsumer)cs).Device);
                        }
                    }
                }
                return availableBluefishIDs;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void NotifyChanged(String info)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(info));            
        }
    }
}
