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
        public BoolMatrix()
        {
            Console.WriteLine("Создание объекта Matrix");
        }
        public BoolMatrix(int size)
        {
            
            Console.WriteLine("Создание объекта Matrix");
            string [] massStrok = new string[size];
            for(int i = 0; i < size; i++)
            {
                massStrok[i] = Console.ReadLine();
            }
            matrix = new bool[size, size];
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    matrix[i, j] = Convert.ToBoolean(massStrok[i][j] - '0');
        }
        public BoolMatrix(string s1 = "000", string s2 = "000", string s3 = "000")
        {
            Console.WriteLine("Создание объекта Matrix");
            bool b1 = Convert.ToBoolean(Convert.ToInt32(s1[0] - '0'));
            bool b2 = Convert.ToBoolean(Convert.ToInt32(s1[1] - '0'));
            bool b3 = Convert.ToBoolean(Convert.ToInt32(s1[2] - '0'));

            bool b4 = Convert.ToBoolean(Convert.ToInt32(s2[0] - '0'));
            bool b5 = Convert.ToBoolean(Convert.ToInt32(s2[1] - '0'));
            bool b6 = Convert.ToBoolean(Convert.ToInt32(s2[2] - '0'));

            bool b7 = Convert.ToBoolean(Convert.ToInt32(s3[0] - '0'));
            bool b8 = Convert.ToBoolean(Convert.ToInt32(s3[1] - '0'));
            bool b9 = Convert.ToBoolean(Convert.ToInt32(s3[2] - '0'));
            matrix = new bool[3, 3] { { b1, b2, b3 }, { b4, b5, b6 }, { b7, b8, b9 } };
        }
        
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

        public void WriteMatrix()
        {
            for (int i = 0; i < matrix.Length / matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.Write("\n");
            }
        }

    }
   
}
