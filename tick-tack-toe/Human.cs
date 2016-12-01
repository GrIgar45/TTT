using System;

namespace tic_tac_toe
{
    /// <summary>
    /// Игрок человек.
    /// </summary>
    class Human : Player
    {
        public Human(TickTackToe TTT, Mark m) : base(TTT, m) { }
        /// <summary>
        /// Ход игрока
        /// </summary>
        /// <param name="X">Х координата</param>
        /// <param name="Y">У координата</param>
        /// <returns>Если истино - действие совершено</returns>
        public bool TakeMove(int X, int Y)
        {
            return gameTTT.MakeMoveCoordinate(X, Y, mark);
        }
    }
}
