namespace tic_tac_toe
{
    /// <summary>
    /// Абстрактный класс игрока. 
    /// </summary>
    abstract class Player
    {
        protected TickTackToe gameTTT;
        protected readonly Mark mark;
        public Player(TickTackToe TTT, Mark m)
        {
            gameTTT = TTT;
            mark = m;
        }
    }
}
