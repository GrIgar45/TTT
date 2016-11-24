using System;
using System.Drawing;
using static System.Math;

namespace tic_tac_toe
{
    class Field
    {
        private const double CLIPPING = 2.5;
        int canvasSizeX, canvasSizeY, renderX, renderY, rows, cols, minCellSize;
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

        int mathRenderX(int minCellSize) => cols * minCellSize;

        int mathRenderY(int minCellSize) => rows * minCellSize;

        int mathLineX(bool end = false) => end ? (canvasSizeX + renderX) / 2 : (canvasSizeX - renderX) / 2;

        int mathLineY(bool end = false) => end ? (canvasSizeY + renderY) / 2 : (canvasSizeY - renderY) / 2;

        public int mathColN(int X) => (X - mathLineX()) / minCellSize;

        public int mathRowN(int Y) => (Y - mathLineY()) / minCellSize;

        public Bitmap DrawFields()
        {
            minCellSize = mathCellSize();
            renderX = mathRenderX(minCellSize);
            renderY = mathRenderY(minCellSize);
            int startLineX = mathLineX();
            int startLineY = mathLineY();
            for (int i = 0; i < cols - 1; i++)
            {
                startLineX += minCellSize;
                gField.DrawLine(linePen, startLineX, startLineY, startLineX, startLineY + renderY);
            }
            startLineX = (canvasSizeX - renderX) / 2;
            for (int i = 0; i < rows - 1; i++)
            {
                startLineY += minCellSize;
                gField.DrawLine(linePen, startLineX, startLineY, startLineX + renderX, startLineY);
            }
            return imgField;
        }

        public void DrawMove(int X, int Y, bool isX)
        {
            if (X < mathLineX() || mathLineX(true) < X) return;
            if (Y < mathLineY() || mathLineY(true) < Y) return;
            int centerX = minCellSize * mathColN(X) + mathLineX() + minCellSize / 2;
            int centerY = minCellSize * mathRowN(Y) + mathLineY() + minCellSize / 2;
            if (isX) DrawX(centerX, centerY);
            else DrawO(centerX, centerY);
        }

        void DrawX(int centerX, int centerY)
        {
            int halfMin = Convert.ToInt32(minCellSize / CLIPPING);
            gField.DrawLine(linePen, centerX - halfMin, centerY - halfMin, centerX + halfMin, centerY + halfMin);
            gField.DrawLine(linePen, centerX - halfMin, centerY + halfMin, centerX + halfMin, centerY - halfMin);
        }

        void DrawO(int centerX, int centerY)
        {
            int halfMin = Convert.ToInt32(minCellSize / CLIPPING);
            gField.DrawEllipse(linePen, centerX - halfMin, centerY - halfMin, halfMin * 2, halfMin * 2);
        }
    }
}