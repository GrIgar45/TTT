using System;
using System.Drawing;
using static System.Math;

namespace tic_tac_toe
{
    /// <summary>
    /// Игровое поле. Позиционирование и отрисовка линий и ходов.
    /// </summary>
    class Field
    {
        private const double CLIPPING = 2.5;
        int canvasSizeX, canvasSizeY, renderX, renderY, rows, cols, сellSize;
        Graphics gField;
        Bitmap imgField;
        Pen linePen;

        public Field(int canvasSizeX, int canvasSizeY, int rows, int cols)
        {
            this.canvasSizeX = canvasSizeX;
            this.canvasSizeY = canvasSizeY;
            this.rows = rows;
            this.cols = cols;
            this.imgField = new Bitmap(canvasSizeX, canvasSizeY);
            this.gField = Graphics.FromImage(imgField);
            linePen = new Pen(Color.Black, 2);
        }

        int mathCellSize()
        {
            int cellWidth = canvasSizeX / cols;
            int cellHeight = canvasSizeY / rows;
            return Min(cellHeight, cellWidth);
        }

        /// <summary>
        /// Определение границ для отрисовки
        /// </summary>
        /// <returns>Ширина отрисовки</returns>
        int mathRenderX() => cols * сellSize;

        /// <summary>
        /// Определение границ для отрисовки
        /// </summary>
        /// <returns>Высота отрисовки</returns>
        int mathRenderY() => rows * сellSize;

        /// <summary>
        /// Определение границы отрисовки по горизонтали
        /// </summary>
        /// <param name="end">Если истинно - возвращается правая граница отрисовки</param>
        /// <returns>Координата границы ширины отрисовки</returns>
        int mathLineX(bool end = false) => end ? (canvasSizeX + renderX) / 2 : (canvasSizeX - renderX) / 2;

        /// <summary>
        /// Определение границы отрисовки по вертикали
        /// </summary>
        /// <param name="end">Если истинно - возвращается нижняя граница отрисовки</param>
        /// <returns>Координата границы высоты отрисовки</returns>
        int mathLineY(bool end = false) => end ? (canvasSizeY + renderY) / 2 : (canvasSizeY - renderY) / 2;

        /// <summary>
        /// Определение номер колонки
        /// </summary>
        /// <param name="X">Координата колонки</param>
        /// <returns>Номер колонки</returns>
        public int mathColN(int X) => (X - mathLineX()) / сellSize;

        /// <summary>
        /// Определение номера строки
        /// </summary>
        /// <param name="Y">Координата строки</param>
        /// <returns>Номер строки</returns>
        public int mathRowN(int Y) => (Y - mathLineY()) / сellSize;

        /// <summary>
        /// Отрисовка линий на поле
        /// </summary>
        /// <returns>Ссылка на изображения поля</returns>
        public Bitmap DrawFields()
        {
            сellSize = mathCellSize();
            renderX = mathRenderX();
            renderY = mathRenderY();
            int startLineX = mathLineX();
            int startLineY = mathLineY();
            for (int i = 0; i < cols - 1; i++)
            {
                startLineX += сellSize;
                gField.DrawLine(linePen, startLineX, startLineY, startLineX, startLineY + renderY);
            }
            startLineX = (canvasSizeX - renderX) / 2;
            for (int i = 0; i < rows - 1; i++)
            {
                startLineY += сellSize;
                gField.DrawLine(linePen, startLineX, startLineY, startLineX + renderX, startLineY);
            }
            return imgField;
        }

        /// <summary>
        /// Отрисовка хода
        /// </summary>
        /// <param name="X">Координата хода по горизонтали</param>
        /// <param name="Y">Координата хода по вертикали</param>
        /// <param name="isX">Если истино - будет отрисован кретик</param>
        public void DrawMove(int X, int Y, bool isX)
        {
            int centerX = сellSize * mathColN(X) + mathLineX() + сellSize / 2;
            int centerY = сellSize * mathRowN(Y) + mathLineY() + сellSize / 2;
            if (isX) DrawX(centerX, centerY);
            else DrawO(centerX, centerY);
        }

        /// <summary>
        /// Отрисовка отметки крестик
        /// </summary>
        /// <param name="centerX">Координата центра по горизонтали</param>
        /// <param name="centerY">Координата центра по вертикали</param>
        void DrawX(int centerX, int centerY)
        {
            int halfMin = Convert.ToInt32(сellSize / CLIPPING);
            gField.DrawLine(linePen, centerX - halfMin, centerY - halfMin, centerX + halfMin, centerY + halfMin);
            gField.DrawLine(linePen, centerX - halfMin, centerY + halfMin, centerX + halfMin, centerY - halfMin);
        }

        /// <summary>
        /// Отрисовка отметки ноль
        /// </summary>
        /// <param name="centerX">Координата центра по горизонтали</param>
        /// <param name="centerY">Координата центра по вертикали</param>
        void DrawO(int centerX, int centerY)
        {
            int halfMin = Convert.ToInt32(сellSize / CLIPPING);
            gField.DrawEllipse(linePen, centerX - halfMin, centerY - halfMin, halfMin * 2, halfMin * 2);
        }
    }
}