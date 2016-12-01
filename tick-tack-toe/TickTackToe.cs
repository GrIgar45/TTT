using System.Drawing;
using System.Collections.Generic;

namespace tic_tac_toe
{
    /// <summary>
    /// Перечисление отметок.
    /// </summary>
    enum Mark { Empty, X, O, NULL };

    /// <summary>
    /// Управление и контроль игры.
    /// </summary>
    class TickTackToe
    {
        Form1 form;
        // Хранение информации о проделаный ходах.
        Mark[,] cells;
        // Размер поля и условие беды.
        readonly int cols, rows, lineToWin;
        // Игровое поле.
        Field myField;
        Point lastMove;

        public Point LastMove { get { return lastMove; } }

        public int LineToWin { get { return lineToWin; } }
        public int Cols { get { return cols; } }
        public int Rows { get { return rows; } }

        public Mark this[int iY, int iX]
        {
            get
            {
                if (iY >= 0 && iX >= 0 && iY < rows && iX < cols)
                {
                    return cells[iY, iX];
                }
                else return Mark.NULL;
            }
        }

        /// <summary>
        /// Констуктор новой игры
        /// </summary>
        /// <param name="canvasSizeX">Размер холста для рисования по горизонтали</param>
        /// <param name="canvasSizeY">Размер холста для рисования по вертикали</param>
        /// <param name="rows">Количество строк</param>
        /// <param name="cols">Количество стлбцов</param>
        public TickTackToe(int canvasSizeX, int canvasSizeY, int rows, int cols, int lineToWin, Form1 f)
        {
            form = f;
            myField = new Field(canvasSizeX, canvasSizeY, rows, cols);
            this.cols = cols;
            this.rows = rows;
            cells = new Mark[rows, cols];
            this.lineToWin = lineToWin;
            lastMove = new Point();
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
        /// Совершение хода при помощи координат
        /// </summary>
        /// <param name="X">Координата по горизонтали</param>
        /// <param name="Y">Координата по вертикали</param>
        /// <param name="mark">Отметка</param>
        /// <returns>Если истинно - ход совершен</returns>
        public bool MakeMoveCoordinate(int X, int Y, Mark mark)
        {
            int iX = myField.mathColN(X);
            if (0 > iX || iX >= cols) return false;
            int iY = myField.mathRowN(Y);
            if (0 > iY || iY >= rows) return false;
            if (cells[iY, iX] != Mark.Empty) return false;
            return MakeMove(iY, iX, mark);
        }

        public bool MakeMove(int iY, int iX, Mark mark)
        {
            cells[iY, iX] = mark;
            myField.DrawMove(iY, iX, mark == Mark.X);
            CheckTheWinner(iY, iX, mark);
            lastMove.Y = iY; lastMove.X = iX;
            return true;
        }

        void CheckTheWinner(int iY, int iX, Mark mark)
        {
            LineToDraw ltd;
            char c = CheckStaightLine(iY, iX, mark, out ltd);
            if (c == ' ')
                c = CheckObliqueLine(iY, iX, mark, ref ltd);
            if (c == ' ')
                return;
            myField.DrawLine(ltd, c);
            string winner = mark == Mark.X ? "Крестики" : "Нолики";
            form.NotifyWinner(winner);
        }

        char CheckStaightLine(int iY, int iX, Mark mark, out LineToDraw ltd)
        {
            ltd = new LineToDraw(iY, iX, iY, iX);
            // Предполагается что текущий ход уже имеет 1 заполненую ячейку
            int totalX = 1, totalY = 1;
            for (int i = 1; i <= lineToWin; i++)
            {
                if (iX + i < cells.GetLength(1))
                {
                    if (cells[iY, iX + i] == mark)
                    {
                        totalX++;
                        ltd.SetEnd(iY, iX + i);
                        continue;
                    }
                }
                break;
            }
            for (int i = 1; i <= lineToWin; i++)
            {
                if (iX - i >= 0)
                {
                    if (cells[iY, iX - i] == mark)
                    {
                        totalX++;
                        ltd.SetStart(iY, iX - i);
                        continue;
                    }
                }
                break;
            }
            if (totalX >= lineToWin)
                return '-';
            for (int j = 1; j <= lineToWin; j++)
            {
                if (iY + j < cells.GetLength(0))
                {
                    if (cells[iY + j, iX] == mark)
                    {
                        totalY++;
                        ltd.SetEnd(iY + j, iX);
                        continue;
                    }
                }
                break;
            }
            for (int j = 1; j <= lineToWin; j++)
            {
                if (iY - j >= 0)
                {
                    if (cells[iY - j, iX] == mark)
                    {
                        totalY++;
                        ltd.SetStart(iY - j, iX);
                        continue;
                    }
                }
                break;
            }
            if (totalY >= lineToWin)
                return '|';
            return ' ';
        }

        char CheckObliqueLine(int iY, int iX, Mark mark, ref LineToDraw ltd)
        {
            ltd.SetStart(iY, iX);
            ltd.SetEnd(iY, iX);
            int forward = 1, backslash = 1;
            for (int i = 1; i <= lineToWin; i++)
            {
                if (iX + i < cells.GetLength(1) && iY + i < cells.GetLength(0))
                {
                    if (cells[iY + i, iX + i] == mark)
                    {
                        forward++;
                        ltd.SetEnd(iY + i, iX + i);
                        continue;
                    }
                }
                break;
            }
            for (int i = 1; i <= lineToWin; i++)
            {
                if (iX - i >= 0 && iY - i >= 0)
                {
                    if (cells[iY - i, iX - i] == mark)
                    {
                        forward++;
                        ltd.SetStart(iY - i, iX - i);
                        continue;
                    }
                }
                break;
            }
            if (forward >= lineToWin)
                return '\\';
            for (int j = 1; j <= lineToWin; j++)
            {
                if (iY - j >= 0 && iX + j < cells.GetLength(1))
                {
                    if (cells[iY - j, iX + j] == mark)
                    {
                        backslash++;
                        ltd.SetEnd(iY - j, iX + j);
                        continue;
                    }
                }
                break;
            }
            for (int j = 1; j <= lineToWin; j++)
            {
                if (iY + j < cells.GetLength(0) && iX - j >= 0)
                {
                    if (cells[iY + j, iX - j] == mark)
                    {
                        backslash++;
                        ltd.SetStart(iY + j, iX - j);
                        continue;
                    }
                }
                break;
            }
            if (backslash >= lineToWin)
                return '/';
            return ' ';
        }
    }
}
