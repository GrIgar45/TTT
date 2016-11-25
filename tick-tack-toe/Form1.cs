using System;
using static System.Math;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        // Игроки. В будущем будут ботами.
        IPlayer current, first, second;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Инициализация новой игры
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            TickTackToe TTT = new TickTackToe(fildPaper.Width, fildPaper.Height, (int)rows.Value, (int)cols.Value);
            first = new Human(TTT, Mark.X);
            second = new Human(TTT, Mark.O);
            current = first;
            fildPaper.Image = TTT.DrawField();
        }

        /// <summary>
        /// Выбор в качестве противника бота
        /// </summary>
        private void radioBot_CheckedChanged(object sender, EventArgs e)
        {
            difficultyPanel.Visible = true;
        }

        /// <summary>
        /// Выбор в качестве противника человека
        /// </summary>
        private void radioHuman_CheckedChanged(object sender, EventArgs e)
        {
            difficultyPanel.Visible = false;
        }

        /// <summary>
        /// Нажатие на поле
        /// </summary>
        private void fildPaper_MouseClick(object sender, MouseEventArgs e)
        {
            if (current == null) return; 
            Human pl = current as Human;
            if (!pl.TakeMove(e.X, e.Y)) return;
            current = (current == first) ? second : first;
            fildPaper.Refresh();
        }

        /// <summary>
        /// Выбор правила 4 в ряд
        /// </summary>
        private void rule4_CheckedChanged(object sender, EventArgs e)
        {
            if (Min((int)rows.Value, (int)cols.Value) < 4)
            {
                rule3.Checked = true;
                return;
            }
        }

        /// <summary>
        /// Выбор правила 5 в ряд
        /// </summary>
        private void rule5_CheckedChanged(object sender, EventArgs e)
        {
            if (Min((int)rows.Value, (int)cols.Value) < 5)
            {
                rule3.Checked = true;
                return;
            }
        }

        /// <summary>
        /// Изменение размера поля
        /// </summary>
        private void cells_ValueChanged(object sender, EventArgs e)
        {
            rule3.Checked = true;
        }
    }
}
