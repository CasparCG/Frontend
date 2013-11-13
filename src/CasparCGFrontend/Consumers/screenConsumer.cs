using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CasparCGFrontend
{
    public class ScreenConsumer : AbstractConsumer, INotifyPropertyChanged
    {
        public ScreenConsumer()
        {
        }

        private String device = "1";
        [XmlElement(ElementName = "device")]
        public String Device
        {
            get { return this.device; }
            set { this.device = value; NotifyChanged("Device"); }
        }

        private string name;
        [XmlElement(ElementName = "name")]
        public string Name
        {
            get { return this.name; }
            set { this.name = value; NotifyChanged("Name"); }
        }
        public bool ShouldSerializeName()
        {
            return name != null && name != "" && name != "ogl";
        }

        private string aspectratio = "default";
        [XmlElement(ElementName = "aspect-ratio")]
        public string AspectRatio
        {
            get { return this.aspectratio; }
            set { this.aspectratio = value; NotifyChanged("AspectRatio"); }
        }
        public bool ShouldSerializeAspectRatio()
        {
            return aspectratio != "default";
        }

        private string stretch = "fill";
        [XmlElement(ElementName = "stretch")]
        public string Stretch
        {
            get { return this.stretch; }
            set { this.stretch = value; NotifyChanged("Stretch"); }
        }
        public bool ShouldSerializeStretch()
        {
            return stretch != "fill" && stretch != "default";
        }

        private Boolean windowed = true;
        [XmlElement(ElementName = "windowed")]
        public Boolean Windowed
        {
            get { return this.windowed; }
            set { this.windowed = value; NotifyChanged("Windowed"); }
        }
        public bool ShouldSerializeWindowed()
        {
            return !windowed;
        }

        private Boolean borderless = false;
        [XmlElement(ElementName = "borderless")]
        public Boolean Borderless
        {
            get { return this.borderless; }
            set { this.borderless = value; NotifyChanged("Borderless"); }
        }
        public bool ShouldSerializeBorderless()
        {
            return borderless;
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

        private Boolean autodeinterlace = true;
        [XmlElement(ElementName = "auto-deinterlace")]
        public Boolean AutoDeinterlace
        {
            get { return this.autodeinterlace; }
            set { this.autodeinterlace = value; NotifyChanged("AutoDeinterlace"); }
        }
        public bool ShouldSerializeAutoDeinterlace()
        {
            return !autodeinterlace;
        }

        private Boolean vsync = false;
        [XmlElement(ElementName = "vsync")]
        public Boolean VSync
        {
            get { return this.vsync; }
            set { this.vsync = value; NotifyChanged("vsync"); }
        }
        public bool ShouldSerializeVSync()
        {
            return vsync;
        }

        public override string ToString()
        {
            return "Screen";
        }

        public override event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void NotifyChanged(String info)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(info));            
        }
    }
}
