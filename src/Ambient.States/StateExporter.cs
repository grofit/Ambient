using System.Xml.Linq;

namespace Ambient.States
{
    public static class StateExporter
    {
        public static XDocument GenerateStateXml(ICompleteState state)
        {
            var xmlDocument = new XDocument();
            var completeStateElement = new XElement("CompleteState");

            var soundStatesElement = new XElement("SoundStates");
            foreach(var soundState in state.SoundStates)
            { soundStatesElement.Add(soundState.GenerateXml()); }
            completeStateElement.Add(soundStatesElement);

            var quickSoundStatesElement = new XElement("QuickSoundStates");
            foreach (var quickSoundState in state.QuickSoundStates)
            { quickSoundStatesElement.Add(quickSoundState.GenerateXml()); }
            completeStateElement.Add(quickSoundStatesElement);

            xmlDocument.Add(completeStateElement);
            return xmlDocument;
        }
    }
}