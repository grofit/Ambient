using System;
using System.Xml.Linq;

namespace Ambient.States
{
    public static class StateImporter
    {
        public static ICompleteState GenerateState(XDocument xmlDocument)
        {
            var completeState = new CompleteState();
            var rootElement = xmlDocument.Element("CompleteState");

            if(rootElement == null)
            { throw new Exception("Error parsing Xml, there is no root node"); }

            var soundStateNodes = rootElement.Elements("SoundStates");
            foreach (var ambientStateNode in soundStateNodes.Elements("SoundState"))
            {
                var soundTypeAttribute = ambientStateNode.Attribute("SoundTypeIdentifier");
                var soundState = SoundStateFactory.GetState(soundTypeAttribute.Value);
                soundState.PopulateFromXml(ambientStateNode);
                completeState.SoundStates.Add(soundState);
            }

            var quickSoundStateNodes = rootElement.Elements("QuickSoundStates");
            foreach (var quickSoundStateNode in quickSoundStateNodes.Elements("SoundState"))
            {
                var soundTypeAttribute = quickSoundStateNode.Attribute("SoundTypeIdentifier");
                var soundState = SoundStateFactory.GetState(soundTypeAttribute.Value);
                soundState.PopulateFromXml(quickSoundStateNode);
                completeState.QuickSoundStates.Add(soundState);
            }

            return completeState;
        }
    }
}
