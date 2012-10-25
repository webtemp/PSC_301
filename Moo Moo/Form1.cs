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
    public partial class Form1 : Form
    {
        private int[] inputedValues = { -1, -1, -1, -1 };
        private int[] acceptedValues = { 8, 46, 36, 35, 34, 33, 37, 38, 39, 40 };
        private bool keyPress = false;
        DataSet ds;

        public Form1()
        {
            // GenerateRandom();
            InitializeComponent();
        }

        private bool isAccepted(int d)
        {
            return acceptedValues.Contains(d);
        }

        private void GuessBox_OnKeyUp(object sender, KeyEventArgs e)
        {
            // Set the digits
            SetDigits();
            
            //Print the numbers to the screen
            PrintGuessingNumber();

            //Disable the selection
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

        private bool CheckForDigits(int digit)
        {
            return inputedValues.Contains(digit);
        }

        private void SetDigits()
        {
            string s = GuessBox.Text.ToString();
            string g;
            for (int i = 0; i < 4; i++)
            {
                try{
                    g = s[i].ToString();
                }
                catch(IndexOutOfRangeException exp)
                {
                    g = "-1";
                }
                inputedValues[i] = int.Parse(g);
            }
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

        private void GuessBox_MouseDown(object sender, MouseEventArgs e)
        {
            DisableSelection();
        }

        private void GuessBox_MouseMove(object sender, MouseEventArgs e)
        {
            DisableSelection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GuessBtn.Enabled = false;
            ds = new DataSet(ref ListTest);
            ds.PrintSet();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int col,val;
            int.TryParse(Col.Value.ToString(), out col);
            int.TryParse(ColValue.Value.ToString(), out val);
            if  ( (col >=0 && col <=3 ) && (val >=0 && val <= 9) )
            {
                ds.RemoveFromCol(col, val);
                ds.PrintSet();
            }
        }
    }

    public class DataSet
    {
        private int[,] List = new int[10, 4];
        Label t;

        public DataSet(ref Label f)
        {
            t = f;
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    List[i, j] = count;
                }
                count++;
            }
        }

        public void PrintSet()
        {
            this.t.Text = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    this.t.Text += List[i, j].ToString() + "   ";
                }
                this.t.Text += "\n";
            }
        }

        public void RemoveFromCol(int col, int val)
        {
            for (int i = 0; i < 10; i++)
            {
                if (List[i, col] == val)
                {
                    List[i, col] = -1;
                }
            }
        }
    }
}
