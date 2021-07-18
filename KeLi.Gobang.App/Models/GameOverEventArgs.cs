using System;

namespace KeLi.Gobang.App.Models
{
    public class GameOverEventArgs : EventArgs
    {
        public GameOverEventArgs(int color)
        {
            Color = color;
        }

        public int Color { get; set; }
    }
}