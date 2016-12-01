using System;
using System.Collections.Generic;
using System.Drawing;

namespace tic_tac_toe
{
    class BotEasy:Player, IBot
    {
        public BotEasy(TickTackToe TTT, Mark m) : base(TTT, m) { }

        public void TakeMove()
        {
            var al = FindPointsToMove();
            Random rnd = new Random();
            if (al.Count != 0)
            {
                var i = rnd.Next(al.Count);
                gameTTT.MakeMove(al[i].Y, al[i].X, mark);
            }
        }

        List<Point> FindPointsToMove()
        {
            var al = new List<Point>();
            var lp = gameTTT.LastMove;
            var i = 0;
            do
            {
                i++;
                if (gameTTT[lp.Y, lp.X - i] == Mark.Empty) al.Add(new Point(lp.X - i, lp.Y));
                if (gameTTT[lp.Y, lp.X + i] == Mark.Empty) al.Add(new Point(lp.X + i, lp.Y));

                if (gameTTT[lp.Y - i, lp.X] == Mark.Empty) al.Add(new Point(lp.X, lp.Y - i));
                if (gameTTT[lp.Y + i, lp.X] == Mark.Empty) al.Add(new Point(lp.X, lp.Y + i));

                if (gameTTT[lp.Y - i, lp.X - i] == Mark.Empty) al.Add(new Point(lp.X - i, lp.Y - i));
                if (gameTTT[lp.Y + i, lp.X + i] == Mark.Empty) al.Add(new Point(lp.X + i, lp.Y + i));

                if (gameTTT[lp.Y - i, lp.X + i] == Mark.Empty) al.Add(new Point(lp.X + i, lp.Y - i));
                if (gameTTT[lp.Y + i, lp.X - i] == Mark.Empty) al.Add(new Point(lp.X - i, lp.Y + i));

            } while (al.Count == 0 && (i < gameTTT.Cols || i < gameTTT.Rows));
            return al;
        }
    }
}
