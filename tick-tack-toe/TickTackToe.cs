using System.Drawing;

namespace tic_tac_toe
{
    enum Mark { Empty, X, O };
    class TickTackToe
    {
        Mark[,] cells;
        bool firstPlayer = false;
        readonly int cols, rows, countLineToW;
        Field myField;

        public TickTackToe(int canvasSizeX, int canvasSizeY, int rows, int cols)
        {
            myField = new Field(canvasSizeX, canvasSizeY, rows, cols);
            this.cols = cols;
            this.rows = rows;
            cells = new Mark[rows, cols];
            return;
        }

        public Bitmap DrawField()
        {
            return myField.DrawFields();
        }

        public bool MakeMove(int X, int Y, Mark mark)
        {
            int iX = myField.mathColN(X);
            int iY = myField.mathRowN(Y);
            if (cells[iY, iX] != Mark.Empty) return false;
            cells[iY, iX] = mark;
            myField.DrawMove(X, Y, mark == Mark.X);
            return true;
        }        
    }
}
