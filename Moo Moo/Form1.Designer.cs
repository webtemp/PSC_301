namespace Moo_Moo
{
    partial class Form1
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
            this.ColValue = new System.Windows.Forms.NumericUpDown();
            this.Col = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.ListTest = new System.Windows.Forms.Label();
            this.ProgBar1 = new System.Windows.Forms.ProgressBar();
            this.TEMP = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.ComputerOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Col)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OutcomeLabel);
            this.groupBox1.Controls.Add(this.GuessBtn);
            this.groupBox1.Controls.Add(this.GuessBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
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
            // 
            // GuessBox
            // 
            this.GuessBox.Location = new System.Drawing.Point(7, 20);
            this.GuessBox.Name = "GuessBox";
            this.GuessBox.Size = new System.Drawing.Size(73, 20);
            this.GuessBox.TabIndex = 0;
            this.GuessBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GuessBox_OnKeyDown);
            this.GuessBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GuessBox_OnKeyUp);
            this.GuessBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GuessBox_MouseDown);
            this.GuessBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GuessBox_MouseMove);
            // 
            // ComputerOutput
            // 
            this.ComputerOutput.Controls.Add(this.ColValue);
            this.ComputerOutput.Controls.Add(this.Col);
            this.ComputerOutput.Controls.Add(this.button1);
            this.ComputerOutput.Controls.Add(this.ListTest);
            this.ComputerOutput.Controls.Add(this.ProgBar1);
            this.ComputerOutput.Controls.Add(this.TEMP);
            this.ComputerOutput.Cursor = System.Windows.Forms.Cursors.No;
            this.ComputerOutput.Location = new System.Drawing.Point(12, 76);
            this.ComputerOutput.Name = "ComputerOutput";
            this.ComputerOutput.Size = new System.Drawing.Size(366, 323);
            this.ComputerOutput.TabIndex = 1;
            this.ComputerOutput.TabStop = false;
            this.ComputerOutput.Text = "Computer Output";
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
            // ListTest
            // 
            this.ListTest.AutoSize = true;
            this.ListTest.Location = new System.Drawing.Point(104, 72);
            this.ListTest.Name = "ListTest";
            this.ListTest.Size = new System.Drawing.Size(55, 13);
            this.ListTest.TabIndex = 2;
            this.ListTest.Text = "The Ma3x";
            // 
            // ProgBar1
            // 
            this.ProgBar1.Location = new System.Drawing.Point(7, 294);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 411);
            this.Controls.Add(this.ComputerOutput);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Moo Moo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ComputerOutput.ResumeLayout(false);
            this.ComputerOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Col)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label OutcomeLabel;
        private System.Windows.Forms.Button GuessBtn;
        private System.Windows.Forms.TextBox GuessBox;
        private System.Windows.Forms.GroupBox ComputerOutput;
        private System.Windows.Forms.Label TEMP;
        private System.Windows.Forms.ProgressBar ProgBar1;
        private System.Windows.Forms.Label ListTest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown ColValue;
        private System.Windows.Forms.NumericUpDown Col;
    }
}

