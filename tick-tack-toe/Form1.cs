using System;
using static System.Math;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        IPlayer current, first, second;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TickTackToe TTT = new TickTackToe(fildPaper.Width, fildPaper.Height, (int)rows.Value, (int)cols.Value);
            first = new Human(TTT, Mark.X);
            second = new Human(TTT, Mark.O);
            current = first;
            fildPaper.Image = TTT.DrawField();
        }

        private void radioBot_CheckedChanged(object sender, EventArgs e)
        {
            difficultyPanel.Visible = true;
        }

        private void radioHuman_CheckedChanged(object sender, EventArgs e)
        {
            difficultyPanel.Visible = false;
        }

        private void fildPaper_MouseClick(object sender, MouseEventArgs e)
        {
            Human pl = current as Human;
            if (!pl.TakeMove(e.X, e.Y)) return;
            current = (current == first) ? second : first;
            fildPaper.Refresh();
        }

        private void rule4_CheckedChanged(object sender, EventArgs e)
        {
            if (Min((int)rows.Value, (int)cols.Value) < 4)
            {
                rule3.Checked = true;
                return;
            }
        }

        private void rule5_CheckedChanged(object sender, EventArgs e)
        {
            if (Min((int)rows.Value, (int)cols.Value) < 5)
            {
                rule3.Checked = true;
                return;
            }
        }

        private void cells_ValueChanged(object sender, EventArgs e)
        {
            rule3.Checked = true;
        }
    }
}
