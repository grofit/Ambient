using System;
using System.Collections.Generic;

namespace Ambient.States
{
    public static class SoundStateFactory
    {
        private static IList<ISoundState> loadedSoundStates;

        static SoundStateFactory()
        {
            loadedSoundStates = new List<ISoundState>()
            {
                new PlayerStates.AmbientState(),
                new PlayerStates.IntervalSoundState(),
                new PlayerStates.QuickSoundState()
            };
        }

        public static ISoundState GetState(string soundTypeIdentifier)
        {
            foreach(var soundState in loadedSoundStates)
            {
                if(soundState.SoundTypeIdentifier == soundTypeIdentifier)
                { return soundState; }
            }
            throw new Exception(string.Format("Unknown Sound State [{0}]", soundTypeIdentifier));
        }
    }
}
