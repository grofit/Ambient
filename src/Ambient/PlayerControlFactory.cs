using System;
using Ambient.Controls.Players;
using Ambient.States;
using Ambient.States.PlayerStates;

namespace Ambient
{
    public static class PlayerControlFactory
    {
        public static IPlayerControl GetSoundControl(ISoundState soundState)
        {
            IPlayerControl playerControl;

            if(soundState is AmbientState)
            { playerControl = new AmbientPlayerControl(); }
            else if(soundState is IntervalSoundState)
            { playerControl = new IntervalSoundPlayerControl(); }
            else
            { throw new Exception(string.Format("Unable to bind state [{0}] to control", soundState.SoundTypeIdentifier)); }

            playerControl.PopulateFromState(soundState);
            return playerControl;
        }
    }
}
