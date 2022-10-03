using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    internal class BoolMatrix
    {
        public bool[,] matrix;
        public bool[,] SumMatrix(bool[,] m1, bool[,] m2)
        {
            bool[,] m3 = new bool [3,3];
            for (int i = 0; i < m1.Length / m1.GetLength(0); i++)
            {
                for (int j = 0; j < m1.GetLength(0); j++)
                {
                    if((m1[i, j] == true && m2[i,j]== true) ||
                        (m1[i, j] == true && m2[i, j] == false) ||
                       (m1[i, j] == false && m2[i, j] == true)) 
                    {
                        m3[i,j] = true;
                    }
                    else if (m1[i, j] == false && m2[i, j] == false)
                    {
                        m3[i, j] = false;
                    }
                }
            }
            return m3;
        }
        public bool[,] MultipltyMatrix(bool[,] m1, bool[,] m2)
        {
            bool[,] m3 = new bool[3, 3];
            for (int i = 0; i < m1.Length / m1.GetLength(0); i++)
            {
                for (int j = 0; j < m1.GetLength(0); j++)
                {
                    if (m1[i, j] == true && m2[i, j] == true) 
                    {
                        m3[i, j] = true;
                    }
                    else if ((m1[i, j] == false && m2[i, j] == false) ||
                        (m1[i, j] == true && m2[i, j] == false) ||
                       (m1[i, j] == false && m2[i, j] == true))
                    {
                        m3[i, j] = false;
                    }
                }
            }
            return m3;
        }
        public bool[,] Inversion(bool[,] m1)
        {
            bool[,] m3 = new bool[3, 3];
            for (int i = 0; i < m1.Length / m1.GetLength(0); i++)
            {
                for (int j = 0; j < m1.GetLength(0); j++)
                {
                    if (m1[i, j] == true)
                    {
                        m3[i, j] = false;
                    }
                    else
                    {
                        m3[i, j] = true;
                    }
                    
                }
            }
            return m3;
        }
        public int Count1()
        {
            int count = 0;

            for (int i = 0; i < this.matrix.Length / this.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrix.GetLength(0); j++)
                {
                    if (this.matrix[i, j] == true)
                    {
                        count++;
                    }

                }
            }
            return count;
        }
    }
}
