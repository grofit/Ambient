using System.Collections.Generic;

namespace Ambient.States
{
    public class CompleteState : ICompleteState
    {
        public IList<ISoundState> SoundStates { get; private set; }
        public IList<ISoundState> QuickSoundStates { get; private set; }

        public CompleteState()
        {
            SoundStates = new List<ISoundState>();
            QuickSoundStates = new List<ISoundState>();
        }
    }
}