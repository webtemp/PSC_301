using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Linq;

namespace Moo_Moo
{
    public class DataSet
    {
        private int[,] Ma3x = new int[10, 4];
        private int[,] Ma3xIndex = new int[10, 4];
        private int[,] Rank = new int[10, 4];
        private SortedList<int, int> NumRank = new SortedList<int, int>();
        private int Tryes = 0;
        private List<int[]> Asked = new List<int[]>();
        private List<int> Current = new List<int>();

        public void ResetRank()
        {
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    Rank[i, j] = 0;
                }
            }
        }

        public void IncreaseRankOf(int c, int val)
        {
            Rank[c, val]++;
        }

        public int GetNextByColumn(int c) { return GetNextByColumn(c, 0); }
        public int GetNextByColumn(int c, int b)
        {
            int tmp, cRank = 10;
            tmp = Ma3x[b, c];
            for (int i = 0; i < 10; i++)
            {
                if (Rank[i, c] < cRank && Ma3x[i,c] != -1)
                {
                    cRank = Rank[i,c];
                }
            }
            //while (Rank[tmp, c] > cRank)
            while (tmp == -1 || (Rank[tmp, c] > cRank))
            {
                tmp = Ma3x[++b, c];
                if (b == 9) { b = 0; }
            }
            return tmp;
        }

        public DataSet()
        {
            /*
            int count = 0;
            for (int i = 0; i < 4; i++)
            {
                count = 0;
                for (int j = 0; j < 10; j++)
                {
                    Ma3x[j, i] = count;
                    Ma3xIndex[j, i] = count++;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                NumRank.Add(i, 0);
            }
            */

            System.Random rand = new System.Random();

            int count = rand.Next(0, 9);
            int[] tmp = new int[10];
            for (int k = 0; k < 10; k++)
            {
                tmp[k] = -1;
            }
            
            for (int j = 0; j < 4; j++)     
            {
                for (int i = 0; i < 10; i++)
                {
                    while (tmp.Contains(count))
                    {
                        count = count == 9 ? 0 : count + 1;
                    }
                    
                    Ma3x[i,j] = count;
                    Ma3xIndex[count, j] = i;
                    tmp[i] = count;
                    // 
                    count = rand.Next(0, 9);                    
                }

                for (int k = 0; k < 10; k++)
                {
                    tmp[k] = -1;
                }
            }
        }

        public void PrintSet(ref Label f)
        {
            f.Text = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    f.Text += Ma3x[i, j].ToString() + "   ";
                }
                f.Text += "\n";
            }
        }

        public void asdf(ref Label f)
        {
            f.Text = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    f.Text += Rank[i, j].ToString() + "   ";
                }
                f.Text += "\n";
            }
        }

        /**
         * Dido made these
         */
        public void RemoveFromCol(int col, int val)
        {
            /*
            for (int i = 0; i < 10; i++)
            {
                if (Ma3x[i, col] == val)
                {
                    Ma3x[i, col] = -1;
                }
            }
             * */

            //ANdy
            Ma3x[Ma3xIndex[val, col], col] = -1;
        }
        public void RemoveExeptCol(int col, int val)
        {
            int tmp = Ma3x[Ma3xIndex[val, col], col];
            RemoveFromMa3x(val);
            Ma3x[Ma3xIndex[val, col], col] = tmp;
        }

        public void RemoveFromMa3x(int val)
        {
            for (int i = 0; i < 4; i++)
            {
                RemoveFromCol(i, val);
            }
        }
    }
}
