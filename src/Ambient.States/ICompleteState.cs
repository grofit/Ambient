using System.Collections.Generic;

namespace Ambient.States
{
    public interface ICompleteState
    {
        IList<ISoundState> SoundStates { get; }
        IList<ISoundState> QuickSoundStates { get; }
    }
}