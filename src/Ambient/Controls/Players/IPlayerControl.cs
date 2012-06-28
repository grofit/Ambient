using System;
using Ambient.States;

namespace Ambient.Controls.Players
{
    public interface IPlayerControl
    {
        event EventHandler Playing, Stopped;

        int ColumnPosition { get; set; }
        int RowPosition { get; set; }

        ISoundState GetState();
        void PopulateFromState(ISoundState soundState);
    }
}
