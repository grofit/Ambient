using System.Xml.Linq;

namespace Ambient.States
{
    public interface ISoundState
    {
        string SoundTypeIdentifier { get; }

        int RowPosition { get; set; }
        int ColumnPosition { get; set; }

        int Volume { get; set; }
        string Filename { get; set; }

        XElement GenerateXml();
        void PopulateFromXml(XElement element);
    }
}