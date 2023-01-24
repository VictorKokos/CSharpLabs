using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal partial class BoolMatrix
    {
        private static int kol { get; set; }
        private static int PrivateCalls { get; set; } = 0;
        public bool[,] matrix;
        private static readonly int standartSize = 3;
        private const int constructorCount = 5;
        public int MatrixSize;
        public BoolMatrix()
        {
            kol++;
            Console.WriteLine("Создание объекта Matrix");
        }
        public BoolMatrix(int size)
        {
            Random rnd = new Random();
            kol++;
            Console.WriteLine("Создание объекта Matrix");
            
            matrix = new bool[size, size];
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                
                    matrix[i, j] = Convert.ToBoolean(rnd.Next(0, 2));
                }
            MatrixSize = size;
        }
        public BoolMatrix(string s1 = "000", string s2 = "000", string s3 = "000")
        {
            kol++;
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

        static BoolMatrix()
        {
            kol = 0;
        }

        private BoolMatrix(bool a)
        {
            PrivateCalls++;
        }

        public bool[,] SumMatrix(bool[,] m1, bool[,] m2)
        {
            bool[,] m3 = new bool[3, 3];
            for (int i = 0; i < m1.Length / m1.GetLength(0); i++)
            {
                for (int j = 0; j < m1.GetLength(0); j++)
                {
                    if ((m1[i, j] == true && m2[i, j] == true) ||
                        (m1[i, j] == true && m2[i, j] == false) ||
                       (m1[i, j] == false && m2[i, j] == true))
                    {
                        m3[i, j] = true;
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
        public bool areEqualSymbols()
        {
            int countInStr = 0;
            int compareTo = -10;
            bool areSame = false;
            for (int j = 0; j < matrix.Length / matrix.GetLength(0); j++)
            {
                for (int k = 0; k < matrix.GetLength(0); k++)
                {
                    if (matrix[j, k] == true)
                    {
                        countInStr++;
                    }
                }
                if (j > 0)
                {
                    if (compareTo != countInStr)
                    {
                        areSame = false; break;
                    }
                }
                compareTo = countInStr;
                areSame = true;
                countInStr = 0;
            }
            if (areSame)
            {
                return true;
            }
            else
            {
                return false;
            }
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
            Console.WriteLine("//////////////////////");
        }

        public void RevertStr(ref string strToRevert)
        {
            char[] chars = strToRevert.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = chars[i] == '0' ? '1' : '0';
            }
            strToRevert = string.Join("", chars); ;
        }

    }

}

