using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Moo_Moo
{
    public partial class MainWindow : Form
    {
        #region Variable Declaration

        private int[] inputedValues = { -1, -1, -1, -1 };
        private int[] acceptedValues = { 8, 46, 36, 35, 34, 33, 37, 38, 39, 40 };
        private bool keyPress = false;
        private int[] question = {-1,-1,-1,-1};
        private bool DEBUG = true; // Only if debugging
        private int cows { get; set; }
        private int bulls { get; set; }
        DataSet ds;
        AboutUs a = new AboutUs();

        #endregion

        #region Intialization

        public MainWindow()
        {
            // GenerateRandom();
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            GuessBtn.Enabled = false;
            ds = new DataSet();
            ds.PrintSet(ref Debugprint);
        }

        #endregion

        #region Input Filter

        private bool isAccepted(int d)
        {
            return acceptedValues.Contains(d);
        }

        private void GuessBox_OnKeyDown(object sender, KeyEventArgs e)
        {
            TEMP.Text =  e.KeyValue.ToString();
            DisableSelection(e.KeyValue);
            if (GuessBox.Text.Length >= 4)
            {
                if (isAccepted(e.KeyValue))
                {
                    return;
                }
                else
                {
                    e.SuppressKeyPress = true;
                }
            }

            if ((char)e.KeyCode >= '0' && (char)e.KeyCode <= '9')
            {
                if (CheckForDigits((int)e.KeyCode - 48))
                {
                    e.SuppressKeyPress = true;
                }
            }
            else if (isAccepted(e.KeyValue)){}
            else
            {
                e.SuppressKeyPress = true;
            }

            if (keyPress)
            {
                e.SuppressKeyPress = true;
            }
            keyPress = true;
        }

        private void GuessBox_OnKeyUp(object sender, KeyEventArgs e)
        {
            // Set the digits
            SetDigits();
            
            // Print the numbers to the screen
            PrintGuessingNumber();

            // Disable the selection
            DisableSelection(e.KeyValue);

            if (GuessBox.Text.Length >= 4)
            {
                GuessBtn.Enabled = true;
                e.SuppressKeyPress = true;
            }
            else
            {
                GuessBtn.Enabled = false;
            }

            int code = (int)e.KeyCode;
            string Text = ((TextBox)sender).Text;
            int Num;
            try
            {
                int DIGITS;
                int.TryParse(Text.Substring(0, 1), out DIGITS);
                int TENS;
                int.TryParse(Text.Substring(1, 1), out TENS);
                int HUNDREDS;
                int.TryParse(Text.Substring(2, 1), out HUNDREDS);
                int THOUSENTS;
                int.TryParse(Text.Substring(3, 1), out THOUSENTS);

                Num = (DIGITS * 1000) + (TENS * 100) + (HUNDREDS * 10) + THOUSENTS;
                //ComputerOutput.Text = Num.ToString();
            }
            catch (ArgumentException afsfsa) { }

            ProgBar1.Value = GuessBox.Text.Length * 25;
            keyPress = false;
        }

        private void SetDigits()
        {
            string s = GuessBox.Text.ToString();
            string g;
            for (int i = 0; i < 4; i++)
            {
                try
                {
                    g = s[i].ToString();
                }
                catch (IndexOutOfRangeException exp)
                {
                    g = "-1";
                }
                inputedValues[i] = int.Parse(g);
            }
        }

        private bool CheckForDigits(int digit)
        {
            return inputedValues.Contains(digit);
        }

        private void DisableSelection(int code = 0)
        {
            int side = 0;
            if (code == 37)
            {
                side = 1;
            }

            if (GuessBox.SelectionLength > 0)
            {
                GuessBox.SelectionStart = GuessBox.SelectionStart + side;
                GuessBox.SelectionLength = 0;
            }
        }

        #endregion

        #region Mouse Filter

        private void GuessBox_MouseDown(object sender, MouseEventArgs e)
        {
            DisableSelection();
        }

        private void GuessBox_MouseMove(object sender, MouseEventArgs e)
        {
            DisableSelection();
        }

        #endregion

        private void PrintGuessingNumber()
        {
            ComputerOutput.Text = "Inputed Values:";
            TEMP.Visible = true;
            TEMP.Text = "";
            foreach( int i in inputedValues)
            {
                TEMP.Text += i + " ";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int col,val;
            int.TryParse(Col.Value.ToString(), out col);
            int.TryParse(ColValue.Value.ToString(), out val);
            if  ( (col >=0 && col <=3 ) && (val >=0 && val <= 9) )
            {
                ds.RemoveFromCol(col, val);
                ds.PrintSet(ref Debugprint);
            }
        }

        private void GuessBtn_Click(object sender, EventArgs e)
        {
            GuessBox.ReadOnly = true;
            GenQuestion();
            Answer();
            CleanMax3();
        }

        private void ResetQuestion()
        {
            for (int i = 0; i < question.Length; i++)
            {
                question[i] = -1;
            }
        }

        private void GenQuestion() 
        {
            ResetQuestion();
            int b = 0,y;

            for (int i = 0; i < 4; i++)
            {
                b = 0;
                y = ds.GetNextByColumn(i, b);
                while(question.Contains(y))
                {
                    y = ds.GetNextByColumn(i,++b);
                    if (b == 9) { b = 0; }
                }
                question[i] = y;
                ds.IncreaseRankOf(y,i);
                ds.asdf(ref Debug2);
            }
        }

        private void Answer()
        {
            cows = bulls = 0;
            for (int i = 0; i < question.Length; i++)
            {
                for (int j = 0; j <question.Length; j++)
                {
                    if (question[i] == inputedValues[j]) 
                    {
                        if (i == j)
                        {
                            bulls++;
                        }
                        else
                        {
                            cows++;
                        }
                    }
                }
            }
            if (DEBUG)
            {
                foreach (var dd in question)
                {
                    GuessingNum.Text += dd.ToString();
                }
                GuessingNum.Text += "C:" + cows + " B:" + bulls + "\n";
            }
        }

        private void CleanMax3()
        {
            if (bulls == 4)
            {
                ResetGame.WithCondition(Condition.LOOSE);
            }
            else if (cows > 0 && bulls == 0)
            {
                for (int i = 0; i < question.Length; i++)
                {
                    ds.RemoveFromCol(i, question[i]);
                }

            }
            else if (bulls > 0 && cows == 0)
            {
                for (int i = 0; i < question.Length; i++)
                {
                    ds.RemoveExeptCol(i, question[i]);
                }
            }
            else if (bulls == 0 && cows == 0)
            {
                for (int i = 0; i < question.Length; i++)
                {
                    ds.RemoveFromMa3x(question[i]);
                }
            }

            ds.PrintSet(ref Realprint);			
        }

        private void GuessBox_TextChanged(object sender, EventArgs e){}

        #region Menu Actions

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetGame.WithCondition(Condition.NEW_GAME);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( a.Visible == false && !a.IsDisposed )
            {
                a.Visible = true;
            }
        }

        #endregion
    }
}