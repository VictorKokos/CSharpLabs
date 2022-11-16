using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Matrix
    {
      

        // поле матрицы
        public int[,] matrix;
        public int size = 0;
        // Конструктор матрицы без параметров
       public Matrix()
        {
            Console.WriteLine("Создание матрицы");
        }

        private void ChooseSize()
        {
            Console.WriteLine("Введите размер матрицы");
             size = Convert.ToInt32(Console.ReadLine());
            matrix = new int[size, size];
        }

        public void FillMatrix()
        {
            ChooseSize();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.WriteLine($"Введите {j+1} элемент {i+1}строки");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            WriteMatrix();
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
