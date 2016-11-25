using System.Drawing;

namespace tic_tac_toe
{
    /// <summary>
    /// Перечисление отметок.
    /// </summary>
    enum Mark { Empty, X, O };

    /// <summary>
    /// Управление и контроль игры.
    /// </summary>
    class TickTackToe
    {
        // Хранение информации о проделаный ходах.
        Mark[,] cells;
        // Размер поля и условие беды.
        readonly int cols, rows, countLineToW;
        // Игровое поле.
        Field myField;

        /// <summary>
        /// Констуктор новой игры
        /// </summary>
        /// <param name="canvasSizeX">Размер холста для рисования по горизонтали</param>
        /// <param name="canvasSizeY">Размер холста для рисования по вертикали</param>
        /// <param name="rows">Количество строк</param>
        /// <param name="cols">Количество стлбцов</param>
        public TickTackToe(int canvasSizeX, int canvasSizeY, int rows, int cols)
        {
            myField = new Field(canvasSizeX, canvasSizeY, rows, cols);
            this.cols = cols;
            this.rows = rows;
            cells = new Mark[rows, cols];
            return;
        }

        /// <summary>
        /// Отрисовка игрового поля
        /// </summary>
        /// <returns>Ссылка на изображения поля</returns>
        public Bitmap DrawField()
        {
            return myField.DrawFields();
        }

        /// <summary>
        /// Совершение хода
        /// </summary>
        /// <param name="X">Координата по горизонтали</param>
        /// <param name="Y">Координата по вертикали</param>
        /// <param name="mark">Отметка</param>
        /// <returns></returns>
        public bool MakeMove(int X, int Y, Mark mark)
        {
            int iX = myField.mathColN(X);
            if (0 > iX || iX >= cols) return false;
            int iY = myField.mathRowN(Y);
            if (0 > iY || iY >= rows) return false;
            if (cells[iY, iX] != Mark.Empty) return false;
            cells[iY, iX] = mark;
            myField.DrawMove(X, Y, mark == Mark.X);
            return true;
        }        
    }
}
