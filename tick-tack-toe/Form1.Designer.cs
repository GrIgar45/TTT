namespace tic_tac_toe
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxRule = new System.Windows.Forms.GroupBox();
            this.rule5 = new System.Windows.Forms.RadioButton();
            this.rule4 = new System.Windows.Forms.RadioButton();
            this.rule3 = new System.Windows.Forms.RadioButton();
            this.groupBoxEnemy = new System.Windows.Forms.GroupBox();
            this.radioHuman = new System.Windows.Forms.RadioButton();
            this.difficultyPanel = new System.Windows.Forms.Panel();
            this.radioHard = new System.Windows.Forms.RadioButton();
            this.radioEasy = new System.Windows.Forms.RadioButton();
            this.radioBot = new System.Windows.Forms.RadioButton();
            this.groupBoxSize = new System.Windows.Forms.GroupBox();
            this.rows = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cols = new System.Windows.Forms.NumericUpDown();
            this.fildPaper = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxRule.SuspendLayout();
            this.groupBoxEnemy.SuspendLayout();
            this.difficultyPanel.SuspendLayout();
            this.groupBoxSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fildPaper)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxRule);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxEnemy);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxSize);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.fildPaper);
            this.splitContainer1.Size = new System.Drawing.Size(480, 382);
            this.splitContainer1.SplitterDistance = 118;
            this.splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(139, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Начать игру";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxRule
            // 
            this.groupBoxRule.Controls.Add(this.rule5);
            this.groupBoxRule.Controls.Add(this.rule4);
            this.groupBoxRule.Controls.Add(this.rule3);
            this.groupBoxRule.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxRule.Location = new System.Drawing.Point(139, 0);
            this.groupBoxRule.Name = "groupBoxRule";
            this.groupBoxRule.Size = new System.Drawing.Size(144, 95);
            this.groupBoxRule.TabIndex = 2;
            this.groupBoxRule.TabStop = false;
            this.groupBoxRule.Text = "Правила";
            // 
            // rule5
            // 
            this.rule5.AutoSize = true;
            this.rule5.Location = new System.Drawing.Point(19, 65);
            this.rule5.Name = "rule5";
            this.rule5.Size = new System.Drawing.Size(80, 17);
            this.rule5.TabIndex = 0;
            this.rule5.Text = "Пять в ряд";
            this.rule5.UseVisualStyleBackColor = true;
            this.rule5.CheckedChanged += new System.EventHandler(this.rule5_CheckedChanged);
            // 
            // rule4
            // 
            this.rule4.AutoSize = true;
            this.rule4.Location = new System.Drawing.Point(19, 42);
            this.rule4.Name = "rule4";
            this.rule4.Size = new System.Drawing.Size(94, 17);
            this.rule4.TabIndex = 0;
            this.rule4.Text = "Четыре в ряд";
            this.rule4.UseVisualStyleBackColor = true;
            this.rule4.CheckedChanged += new System.EventHandler(this.rule4_CheckedChanged);
            // 
            // rule3
            // 
            this.rule3.AutoSize = true;
            this.rule3.Checked = true;
            this.rule3.Location = new System.Drawing.Point(19, 19);
            this.rule3.Name = "rule3";
            this.rule3.Size = new System.Drawing.Size(74, 17);
            this.rule3.TabIndex = 0;
            this.rule3.TabStop = true;
            this.rule3.Text = "Три в ряд";
            this.rule3.UseVisualStyleBackColor = true;
            this.rule3.CheckedChanged += new System.EventHandler(this.rule3_CheckedChanged);
            // 
            // groupBoxEnemy
            // 
            this.groupBoxEnemy.Controls.Add(this.radioHuman);
            this.groupBoxEnemy.Controls.Add(this.difficultyPanel);
            this.groupBoxEnemy.Controls.Add(this.radioBot);
            this.groupBoxEnemy.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxEnemy.Location = new System.Drawing.Point(283, 0);
            this.groupBoxEnemy.Name = "groupBoxEnemy";
            this.groupBoxEnemy.Size = new System.Drawing.Size(197, 118);
            this.groupBoxEnemy.TabIndex = 1;
            this.groupBoxEnemy.TabStop = false;
            this.groupBoxEnemy.Text = "Выбор противника";
            // 
            // radioHuman
            // 
            this.radioHuman.AutoSize = true;
            this.radioHuman.Checked = true;
            this.radioHuman.Location = new System.Drawing.Point(9, 19);
            this.radioHuman.Name = "radioHuman";
            this.radioHuman.Size = new System.Drawing.Size(69, 17);
            this.radioHuman.TabIndex = 0;
            this.radioHuman.TabStop = true;
            this.radioHuman.Text = "Человек";
            this.radioHuman.UseVisualStyleBackColor = true;
            this.radioHuman.CheckedChanged += new System.EventHandler(this.radioHuman_CheckedChanged);
            // 
            // difficultyPanel
            // 
            this.difficultyPanel.AutoSize = true;
            this.difficultyPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.difficultyPanel.Controls.Add(this.radioHard);
            this.difficultyPanel.Controls.Add(this.radioEasy);
            this.difficultyPanel.Location = new System.Drawing.Point(6, 54);
            this.difficultyPanel.Name = "difficultyPanel";
            this.difficultyPanel.Size = new System.Drawing.Size(169, 23);
            this.difficultyPanel.TabIndex = 2;
            this.difficultyPanel.Visible = false;
            // 
            // radioHard
            // 
            this.radioHard.AutoSize = true;
            this.radioHard.Location = new System.Drawing.Point(94, 3);
            this.radioHard.Name = "radioHard";
            this.radioHard.Size = new System.Drawing.Size(72, 17);
            this.radioHard.TabIndex = 4;
            this.radioHard.TabStop = true;
            this.radioHard.Text = "Сложный";
            this.radioHard.UseVisualStyleBackColor = true;
            // 
            // radioEasy
            // 
            this.radioEasy.AutoSize = true;
            this.radioEasy.Checked = true;
            this.radioEasy.Location = new System.Drawing.Point(3, 3);
            this.radioEasy.Name = "radioEasy";
            this.radioEasy.Size = new System.Drawing.Size(62, 17);
            this.radioEasy.TabIndex = 3;
            this.radioEasy.TabStop = true;
            this.radioEasy.Text = "Лёгкий";
            this.radioEasy.UseVisualStyleBackColor = true;
            // 
            // radioBot
            // 
            this.radioBot.AutoSize = true;
            this.radioBot.Location = new System.Drawing.Point(100, 19);
            this.radioBot.Name = "radioBot";
            this.radioBot.Size = new System.Drawing.Size(77, 17);
            this.radioBot.TabIndex = 1;
            this.radioBot.Text = "Компютер";
            this.radioBot.UseVisualStyleBackColor = true;
            this.radioBot.CheckedChanged += new System.EventHandler(this.radioBot_CheckedChanged);
            // 
            // groupBoxSize
            // 
            this.groupBoxSize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxSize.Controls.Add(this.rows);
            this.groupBoxSize.Controls.Add(this.label1);
            this.groupBoxSize.Controls.Add(this.cols);
            this.groupBoxSize.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxSize.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSize.Name = "groupBoxSize";
            this.groupBoxSize.Size = new System.Drawing.Size(139, 118);
            this.groupBoxSize.TabIndex = 0;
            this.groupBoxSize.TabStop = false;
            this.groupBoxSize.Text = "Размер поля";
            // 
            // rows
            // 
            this.rows.AutoSize = true;
            this.rows.Location = new System.Drawing.Point(82, 36);
            this.rows.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.rows.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.rows.Name = "rows";
            this.rows.Size = new System.Drawing.Size(47, 20);
            this.rows.TabIndex = 2;
            this.rows.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.rows.ValueChanged += new System.EventHandler(this.cells_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // cols
            // 
            this.cols.AutoSize = true;
            this.cols.Location = new System.Drawing.Point(9, 36);
            this.cols.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.cols.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.cols.Name = "cols";
            this.cols.Size = new System.Drawing.Size(47, 20);
            this.cols.TabIndex = 0;
            this.cols.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.cols.ValueChanged += new System.EventHandler(this.cells_ValueChanged);
            // 
            // fildPaper
            // 
            this.fildPaper.BackColor = System.Drawing.Color.White;
            this.fildPaper.Cursor = System.Windows.Forms.Cursors.Cross;
            this.fildPaper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fildPaper.Enabled = false;
            this.fildPaper.Location = new System.Drawing.Point(0, 0);
            this.fildPaper.Name = "fildPaper";
            this.fildPaper.Size = new System.Drawing.Size(480, 260);
            this.fildPaper.TabIndex = 0;
            this.fildPaper.TabStop = false;
            this.fildPaper.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fildPaper_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 382);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(475, 400);
            this.Name = "Form1";
            this.Text = "Крестики-нолики";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxRule.ResumeLayout(false);
            this.groupBoxRule.PerformLayout();
            this.groupBoxEnemy.ResumeLayout(false);
            this.groupBoxEnemy.PerformLayout();
            this.difficultyPanel.ResumeLayout(false);
            this.difficultyPanel.PerformLayout();
            this.groupBoxSize.ResumeLayout(false);
            this.groupBoxSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fildPaper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxSize;
        private System.Windows.Forms.NumericUpDown rows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown cols;
        private System.Windows.Forms.GroupBox groupBoxEnemy;
        private System.Windows.Forms.RadioButton radioBot;
        private System.Windows.Forms.RadioButton radioHuman;
        private System.Windows.Forms.Panel difficultyPanel;
        private System.Windows.Forms.RadioButton radioHard;
        private System.Windows.Forms.RadioButton radioEasy;
        private System.Windows.Forms.GroupBox groupBoxRule;
        private System.Windows.Forms.RadioButton rule5;
        private System.Windows.Forms.RadioButton rule4;
        private System.Windows.Forms.RadioButton rule3;
        private System.Windows.Forms.PictureBox fildPaper;
        private System.Windows.Forms.Button button1;
    }
}

