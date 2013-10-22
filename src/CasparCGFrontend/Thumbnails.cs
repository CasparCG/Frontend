using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CasparCGFrontend
{
    public class Thumbnails : INotifyPropertyChanged
    {
        public Thumbnails() { }

        private bool generateThumbnails = true;
        [XmlElement(ElementName = "generate-thumbnails")]
        public bool GenerateThumbnails
        {
            get { return this.generateThumbnails; }
            set { this.generateThumbnails = value; NotifyChanged("GenerateThumbnails"); }
        }
        public bool ShouldSerializeGenerateThumbnails()
        {
            return !generateThumbnails;
        }

        private int width = 256;
        [XmlElement(ElementName = "width")]
        public int Width
        {
            get { return this.width; }
            set { this.width = value; NotifyChanged("Width"); }
        }
        public bool ShouldSerializeWidth()
        {
            return width != 256;
        }

        private int height = 144;
        [XmlElement(ElementName = "height")]
        public int Height
        {
            get { return this.height; }
            set { this.height = value; NotifyChanged("Height"); }
        }
        public bool ShouldSerializeHeight()
        {
            return height != 144;
        }

        private int videoGrid = 2;
        [XmlElement(ElementName = "video-grid")]
        public int VideoGrid
        {
            get { return this.videoGrid; }
            set { this.videoGrid = value; NotifyChanged("VideoGrid"); }
        }
        public bool ShouldSerializeVideoGrid()
        {
            return videoGrid != 2;
        }

        private int scanIntervallMillis = 5000;
        [XmlElement(ElementName = "scan-interval-millis")]
        public int ScanIntervallMillis
        {
            get { return this.scanIntervallMillis; }
            set { this.scanIntervallMillis = value; NotifyChanged("ScanIntervallMillis"); }
        }
        public bool ShouldSerializeScanIntervallMillis()
        {
            return scanIntervallMillis != 5000;
        }

        private int generateDelayMillis = 2000;
        [XmlElement(ElementName = "generate-delay-millis")]
        public int GenerateDelayMillis
        {
            get { return this.generateDelayMillis; }
            set { this.generateDelayMillis = value; NotifyChanged("GenerateDelayMillis"); }
        }
        public bool ShouldSerializeGenerateDelayMillis()
        {
            return generateDelayMillis != 2000;
        }

        private string videoMode = "720p2500";
        [XmlElement(ElementName = "video-mode")]
        public string VideoMode
        {
            get { return this.videoMode; }
            set { this.videoMode = value; NotifyChanged("VideoMode"); }
        }
        public bool ShouldSerializeVideoMode()
        {
            return videoMode != "720p2500";
        }

        public bool IsOnlyDefaultValues()
        {
            return !ShouldSerializeGenerateThumbnails()
                && !ShouldSerializeWidth()
                && !ShouldSerializeHeight()
                && !ShouldSerializeVideoGrid()
                && !ShouldSerializeScanIntervallMillis()
                && !ShouldSerializeGenerateDelayMillis()
                && !ShouldSerializeVideoMode();
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void NotifyChanged(String info)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(info));
        }
    }
}
