using System;

namespace tic_tac_toe
{
    /// <summary>
    /// Игрок человек.
    /// </summary>
    class Human: IPlayer
    {
        TickTackToe gameTTT;
        readonly Mark mark;
        public Human(TickTackToe TTT, Mark m)
        {
            gameTTT = TTT;
            mark = m;
        }

        public bool TakeMove(int X, int Y)
        {
            return gameTTT.MakeMove(X, Y, mark);
        }
    }
}
