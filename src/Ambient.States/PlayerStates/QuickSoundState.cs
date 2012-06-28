using System;
using System.Xml.Linq;

namespace Ambient.States.PlayerStates
{
    public class QuickSoundState : ISoundState
    {
        public string SoundTypeIdentifier
        {
            get { return GetType().ToString(); }
        }

        public int RowPosition { get; set; }
        public int ColumnPosition { get; set; }

        public int Volume { get; set; }
        public string Filename { get; set; }

        public XElement GenerateXml()
        {
            var xmlElement = new XElement("SoundState");
            xmlElement.Add(new XAttribute("SoundTypeIdentifier", SoundTypeIdentifier));
            xmlElement.Add(new XAttribute("RowPosition", RowPosition.ToString()));
            xmlElement.Add(new XAttribute("ColumnPosition", ColumnPosition.ToString()));
            xmlElement.Add(new XAttribute("Volume", Volume.ToString()));
            xmlElement.Add(new XAttribute("Filename", Filename));
            return xmlElement;
        }

        public void PopulateFromXml(XElement element)
        {
            RowPosition = Convert.ToInt32(element.Attribute("RowPosition").Value);
            ColumnPosition = Convert.ToInt32(element.Attribute("ColumnPosition").Value);

            Filename = element.Attribute("Filename").Value;
            Volume = Convert.ToInt32(element.Attribute("Volume").Value);
        }
    }
}