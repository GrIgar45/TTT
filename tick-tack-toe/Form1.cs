using System;
using static System.Math;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        // Игроки.
        Player current, first, second;
        // Если кто то выиграл - боту уже ходить не нужно
        bool gameIsContinue;
        int lineToWin = 3;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Инициализация новой игры
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            // Новая игра
            TickTackToe TTT = new TickTackToe(fildPaper.Width, fildPaper.Height, (int)rows.Value, (int)cols.Value, lineToWin, this);
            // Новые игроки
            first = new Human(TTT, Mark.X);
            if (radioBot.Checked)
                second = new BotEasy(TTT, Mark.O);
            else
                second = new Human(TTT, Mark.O);
            // Крестики всегда первыми
            current = first;
            // Возможность ходить и отрисовка поля
            fildPaper.Enabled = true;
            fildPaper.Image = TTT.DrawField();
            gameIsContinue = true;
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
            Human pl = current as Human;
            if (!pl.TakeMove(e.X, e.Y)) return;

            if (second is IBot && gameIsContinue)
            {
                var sc = second as IBot;
                sc.TakeMove();
                fildPaper.Refresh();
                return;
            }
            current = (current == first) ? second : first;
            fildPaper.Refresh();
        }

        /// <summary>
        /// Выбор правила 3 в ряд
        /// </summary>
        private void rule3_CheckedChanged(object sender, EventArgs e)
        {
            lineToWin = 3;
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
            lineToWin = 4;
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
            lineToWin = 5;
        }

        /// <summary>
        /// Изменение размера поля
        /// По нормальному, ссылку на этот метод нужно передать как делегат
        /// </summary>
        private void cells_ValueChanged(object sender, EventArgs e)
        {
            rule3.Checked = true;
        }

        public void NotifyWinner(string winner)
        {
            MessageBox.Show($"Победитель :{winner}");
            gameIsContinue = false;
            fildPaper.Enabled = false;
        }
    }
}
