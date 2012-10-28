namespace Moo_Moo
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OutcomeLabel = new System.Windows.Forms.Label();
            this.GuessBtn = new System.Windows.Forms.Button();
            this.GuessBox = new System.Windows.Forms.TextBox();
            this.ComputerOutput = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Debug2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GuessingNum = new System.Windows.Forms.Label();
            this.Realprint = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Debugprint = new System.Windows.Forms.Label();
            this.ColValue = new System.Windows.Forms.NumericUpDown();
            this.Col = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.ProgBar1 = new System.Windows.Forms.ProgressBar();
            this.TEMP = new System.Windows.Forms.Label();
            this.MenuGroup = new System.Windows.Forms.MenuStrip();
            this.MenuMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.ComputerOutput.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Col)).BeginInit();
            this.MenuGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OutcomeLabel);
            this.groupBox1.Controls.Add(this.GuessBtn);
            this.groupBox1.Controls.Add(this.GuessBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Values";
            // 
            // OutcomeLabel
            // 
            this.OutcomeLabel.AutoSize = true;
            this.OutcomeLabel.Location = new System.Drawing.Point(217, 20);
            this.OutcomeLabel.Name = "OutcomeLabel";
            this.OutcomeLabel.Size = new System.Drawing.Size(0, 13);
            this.OutcomeLabel.TabIndex = 2;
            this.OutcomeLabel.Visible = false;
            // 
            // GuessBtn
            // 
            this.GuessBtn.Location = new System.Drawing.Point(86, 18);
            this.GuessBtn.Name = "GuessBtn";
            this.GuessBtn.Size = new System.Drawing.Size(73, 23);
            this.GuessBtn.TabIndex = 1;
            this.GuessBtn.Text = "Guess";
            this.GuessBtn.UseVisualStyleBackColor = true;
            this.GuessBtn.Click += new System.EventHandler(this.GuessBtn_Click);
            // 
            // GuessBox
            // 
            this.GuessBox.Location = new System.Drawing.Point(7, 20);
            this.GuessBox.Name = "GuessBox";
            this.GuessBox.Size = new System.Drawing.Size(73, 20);
            this.GuessBox.TabIndex = 0;
            this.GuessBox.TextChanged += new System.EventHandler(this.GuessBox_TextChanged);
            this.GuessBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GuessBox_OnKeyDown);
            this.GuessBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GuessBox_OnKeyUp);
            this.GuessBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GuessBox_MouseDown);
            this.GuessBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GuessBox_MouseMove);
            // 
            // ComputerOutput
            // 
            this.ComputerOutput.Controls.Add(this.groupBox4);
            this.ComputerOutput.Controls.Add(this.groupBox3);
            this.ComputerOutput.Controls.Add(this.groupBox2);
            this.ComputerOutput.Controls.Add(this.ColValue);
            this.ComputerOutput.Controls.Add(this.Col);
            this.ComputerOutput.Controls.Add(this.button1);
            this.ComputerOutput.Controls.Add(this.ProgBar1);
            this.ComputerOutput.Controls.Add(this.TEMP);
            this.ComputerOutput.Cursor = System.Windows.Forms.Cursors.No;
            this.ComputerOutput.Location = new System.Drawing.Point(12, 94);
            this.ComputerOutput.Name = "ComputerOutput";
            this.ComputerOutput.Size = new System.Drawing.Size(366, 524);
            this.ComputerOutput.TabIndex = 1;
            this.ComputerOutput.TabStop = false;
            this.ComputerOutput.Text = "Computer Output";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Debug2);
            this.groupBox4.Location = new System.Drawing.Point(9, 294);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(162, 193);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Debug 2";
            // 
            // Debug2
            // 
            this.Debug2.AutoSize = true;
            this.Debug2.Location = new System.Drawing.Point(6, 16);
            this.Debug2.Name = "Debug2";
            this.Debug2.Size = new System.Drawing.Size(45, 13);
            this.Debug2.TabIndex = 2;
            this.Debug2.Text = "Debug2";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.GuessingNum);
            this.groupBox3.Controls.Add(this.Realprint);
            this.groupBox3.Location = new System.Drawing.Point(177, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(183, 193);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Real data";
            // 
            // GuessingNum
            // 
            this.GuessingNum.AutoSize = true;
            this.GuessingNum.Location = new System.Drawing.Point(110, 19);
            this.GuessingNum.Name = "GuessingNum";
            this.GuessingNum.Size = new System.Drawing.Size(0, 13);
            this.GuessingNum.TabIndex = 1;
            // 
            // Realprint
            // 
            this.Realprint.AutoSize = true;
            this.Realprint.Location = new System.Drawing.Point(7, 20);
            this.Realprint.Name = "Realprint";
            this.Realprint.Size = new System.Drawing.Size(49, 13);
            this.Realprint.TabIndex = 0;
            this.Realprint.Text = "Realprint";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Debugprint);
            this.groupBox2.Location = new System.Drawing.Point(9, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 193);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Debug";
            // 
            // Debugprint
            // 
            this.Debugprint.AutoSize = true;
            this.Debugprint.Location = new System.Drawing.Point(6, 16);
            this.Debugprint.Name = "Debugprint";
            this.Debugprint.Size = new System.Drawing.Size(59, 13);
            this.Debugprint.TabIndex = 2;
            this.Debugprint.Text = "Debugprint";
            // 
            // ColValue
            // 
            this.ColValue.Location = new System.Drawing.Point(288, 14);
            this.ColValue.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.ColValue.Name = "ColValue";
            this.ColValue.Size = new System.Drawing.Size(35, 20);
            this.ColValue.TabIndex = 5;
            // 
            // Col
            // 
            this.Col.Location = new System.Drawing.Point(327, 14);
            this.Col.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Col.Name = "Col";
            this.Col.Size = new System.Drawing.Size(33, 20);
            this.Col.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProgBar1
            // 
            this.ProgBar1.Location = new System.Drawing.Point(9, 493);
            this.ProgBar1.Name = "ProgBar1";
            this.ProgBar1.Size = new System.Drawing.Size(353, 23);
            this.ProgBar1.TabIndex = 1;
            // 
            // TEMP
            // 
            this.TEMP.AutoSize = true;
            this.TEMP.Location = new System.Drawing.Point(6, 16);
            this.TEMP.Name = "TEMP";
            this.TEMP.Size = new System.Drawing.Size(0, 13);
            this.TEMP.TabIndex = 0;
            // 
            // MenuGroup
            // 
            this.MenuGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMenu,
            this.HelpMenu});
            this.MenuGroup.Location = new System.Drawing.Point(0, 0);
            this.MenuGroup.Name = "MenuGroup";
            this.MenuGroup.Size = new System.Drawing.Size(390, 24);
            this.MenuGroup.TabIndex = 2;
            this.MenuGroup.Text = "Program Window";
            // 
            // MenuMenu
            // 
            this.MenuMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MenuMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.MenuMenu.Name = "MenuMenu";
            this.MenuMenu.Size = new System.Drawing.Size(45, 20);
            this.MenuMenu.Text = "&Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.newGameToolStripMenuItem.Text = "&New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(40, 20);
            this.HelpMenu.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 625);
            this.Controls.Add(this.ComputerOutput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MenuGroup);
            this.MainMenuStrip = this.MenuGroup;
            this.Name = "MainWindow";
            this.Text = "Moo Moo";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ComputerOutput.ResumeLayout(false);
            this.ComputerOutput.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Col)).EndInit();
            this.MenuGroup.ResumeLayout(false);
            this.MenuGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label OutcomeLabel;
        private System.Windows.Forms.Button GuessBtn;
        private System.Windows.Forms.TextBox GuessBox;
        private System.Windows.Forms.GroupBox ComputerOutput;
        private System.Windows.Forms.Label TEMP;
        private System.Windows.Forms.ProgressBar ProgBar1;
        private System.Windows.Forms.Label Debugprint;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown ColValue;
        private System.Windows.Forms.NumericUpDown Col;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label Realprint;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label GuessingNum;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label Debug2;
        private System.Windows.Forms.MenuStrip MenuGroup;
        private System.Windows.Forms.ToolStripMenuItem MenuMenu;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

