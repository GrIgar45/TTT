using System;
using System.Collections.Generic;
using System.Drawing;
using static System.Math;
using System.Threading.Tasks;

namespace tic_tac_toe
{
    class BotHard : BotEasy, IBot
    {

        struct cell
        {
            public int Def { get; set; }
            public int Atc { get; set; }
        }

        cell[,] cells;
        public BotHard(TickTackToe TTT, Mark m) : base(TTT, m) { cells = new cell[gameTTT.Rows, gameTTT.Cols]; }

        public void TakeMove()
        {
            countedAroundCell();
            int mYD = 0, mXD = 0, mYA = 0, mXA = 0;
            int maxA = cells[mYA, mXA].Atc, maxD = cells[mYD, mXD].Def;
            bool findMove = false;
            // Находим найболее важные точки
            for (int i = 0; i < cells.GetLength(0); i++)
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    if (cells[i, j].Atc > maxA)
                    {
                        maxA = cells[i, j].Atc;
                        mYA = i; mXA = j;
                        findMove = true;
                    }
                    if (cells[i, j].Def > maxD)
                    {
                        maxD = cells[i, j].Def;
                        mYD = i; mXD = j;
                        findMove = true;
                    }
                }
            // Оптимального хода нету?
            if (!findMove)
            {
                // Ходим случайным образом
                var al = FindPointsToMove();
                Random rnd = new Random();
                if (al.Count != 0)
                {
                    var i = rnd.Next(al.Count);
                    gameTTT.MakeMove(al[i].Y, al[i].X, mark);
                }
            }
            // Лучше защитится или атаковать?
            else if (maxD >= maxA)
            {
                gameTTT.MakeMove(mYD, mXD, mark);
            }
            else
            {
                gameTTT.MakeMove(mYA, mXA, mark);
            }
        }

        /// <summary>
        /// Перерасчет весов ячеек
        /// </summary>
        void countedAroundCell()
        {
            for (int i = 0; i < cells.GetLength(0); i++)
                for (int j = 0; j < cells.GetLength(1); j++) {
                    if (gameTTT[i, j] == Mark.Empty)
                    {
                        cells[i, j].Atc = countedCell(i, j, Mark.O);
                        cells[i, j].Def = countedCell(i, j, Mark.X);
                    }
                    else
                    {
                        cells[i, j].Atc = -1;
                        cells[i, j].Def = -1;
                    }
                }
        }

        /// <summary>
        /// Перерасчет важности ячейки
        /// </summary>
        /// <param name="Y">Номер строки</param>
        /// <param name="X">Номер столбца</param>
        /// <param name="m">Отметка</param>
        /// <returns>Вес ячейки</returns>
        int countedCell(int Y, int X, Mark m)
        {
            int[] dirs = new int[8];
            // ↑
            dirs[0] = countLine(Y, X, -1, 0, m);
            // ↓
            dirs[1] = countLine(Y, X, 1, 0, m);
            // ←
            dirs[2] = countLine(Y, X, 0, -1, m);
            // →
            dirs[3] = countLine(Y, X, 0, 1, m);
            // ↖
            dirs[4] = countLine(Y, X, -1, -1, m);
            // ↘
            dirs[5] = countLine(Y, X, 1, 1, m);
            // ↗
            dirs[6] = countLine(Y, X, -1, 1, m);
            // ↙
            dirs[7] = countLine(Y, X, 1, -1, m);
            Array.Sort(dirs);
            return dirs[dirs.Length - 1];
        }

        /// <summary>
        /// Определение важности ячейки по направляющей линии
        /// </summary>
        /// <param name="Y">Номер строки</param>
        /// <param name="X">Номер столбца</param>
        /// <param name="shiftY">Сдвиг по вертикали (0 - нет сдвига. -1 вверх. 1 вниз)</param>
        /// <param name="shiftX">Сдвиг по горизонтали (0 - нет сдвига. -1 влево. 1 вправо)</param>
        /// <param name="m">Отметка</param>
        /// <returns>Вес линии по отметке</returns>
        int countLine(int Y, int X, int shiftY, int shiftX, Mark m)
        {
            int n = 0, i = shiftY, j = shiftX, c = 0;
            while (c < gameTTT.LineToWin - 1)
            {
                if (gameTTT[Y + i, X + j] == m)
                    n++;
                else if (gameTTT[Y + i, X + j] != Mark.Empty)
                {
                    n = -1;
                    break;
                }
                else
                    break;
                i += shiftY; j += shiftX;
                c++;
            }
            return n;
        }
    }
}
