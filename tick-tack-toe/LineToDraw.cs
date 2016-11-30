using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe
{
    /// <summary>
    /// Хранит координату для отметки
    /// </summary>
    class LineToDraw
    {
        public LineToDraw(int startY, int startX, int endY, int endX)
        {
            StartX = startX;
            StartY = startY;
            EndX = endX;
            EndY = endY;
        }

        public void SetStart(int Y, int X)
        {
            StartY = Y;
            StartX = X;
        }

        public void SetEnd(int Y, int X)
        {
            EndY = Y;
            EndX = X;
        }

        public int StartX { get; private set; }
        public int StartY { get; private set; }
        public int EndX { get; private set; }
        public int EndY { get; private set; }
    }
}
