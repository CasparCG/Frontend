using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CasparCGFrontend
{
    public class Mixer : INotifyPropertyChanged
    {
        public Mixer() { }

        private Boolean blendModes = false;
        [XmlElement(ElementName = "blend-modes")]
        public Boolean BlendModes
        {
            get { return this.blendModes; }
            set { this.blendModes = value; NotifyChanged("BlendModes"); }
        }
        public bool ShouldSerializeBlendModes()
        {
            return blendModes;
        }

        private Boolean straightAlpha = false;
        [XmlElement(ElementName = "straight-alpha")]
        public Boolean StraightAlpha
        {
            get { return this.straightAlpha; }
            set { this.straightAlpha = value; NotifyChanged("StraightAlpha"); }
        }
        public bool ShouldSerializeStraightAlpha()
        {
            return straightAlpha;
        }

        private Boolean chromaKey = false;
        [XmlElement(ElementName = "chroma-key")]
        public Boolean ChromaKey
        {
            get { return this.chromaKey; }
            set { this.chromaKey = value; NotifyChanged("ChromaKey"); }
        }
        public bool ShouldSerializeChromaKey()
        {
            return chromaKey;
        }

        private Boolean mipmappingDefaultOn = false;
        [XmlElement(ElementName = "mipmapping_default_on")]
        public Boolean MipmappingDefaultOn
        {
            get { return this.mipmappingDefaultOn; }
            set { this.mipmappingDefaultOn = value; NotifyChanged("MipmappingDefaultOn"); }
        }
        public bool ShouldSerializeMipmappingDefaultOn()
        {
            return mipmappingDefaultOn == true;
        }

        public bool IsOnlyDefaultValues()
        {
            return !ShouldSerializeBlendModes()
                && !ShouldSerializeChromaKey()
                && !ShouldSerializeStraightAlpha()
                && !ShouldSerializeMipmappingDefaultOn();
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void NotifyChanged(String info)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(info));
        }
    }
}
