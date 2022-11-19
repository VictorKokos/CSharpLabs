using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{


    public class Matrix
    {

        // поля матрицы и её размера
        public int[,] matrix;
        public int size = 0;
        public string name;
        //перегрузка оператора +
        public static Matrix operator +(Matrix obj1, Matrix obj2)
        {
            Matrix sum = new Matrix("Sum", obj1.size);
            sum.matrix = new int[obj1.size, obj1.size];
            for (int i = 0; i < obj1.size; i++)
            {
                for (int j = 0; j < obj1.size; j++)
                {
                    sum.matrix[i, j] = obj1.matrix[i, j] + obj2.matrix[i, j];
                }
            }
           
            return sum;
        }
        //обнуление всех элементов матрицы
        public static Matrix operator -( Matrix obj)
        {
            Console.WriteLine($"Обнуление всех элементов матрицы {obj.name}");
            for (int i = 0; i < obj.size; i++)
            {
                for (int j = 0; j < obj.size; j++)
                {
                    obj.matrix[i, j] = 0;
                }
            }
            

            return obj;
        }
        //Сравнение матриц по нулевому столбцу
        public static bool operator ==(Matrix obj1, Matrix obj2)
        {
            bool areZeroColumnEquals = true;
            for(int i = 0; i < obj1.size; i++)
            {
                if (obj1.matrix[i, 0] != obj2.matrix[i,0])
                {
                    areZeroColumnEquals = false;
                }
            }
            
           
            return areZeroColumnEquals;
        }
        public static bool operator !=(Matrix obj1, Matrix obj2)
        {
            bool areZeroColumnEquals = true;
            for (int i = 0; i < obj1.size; i++)
            {
                if (obj1.matrix[i, 0] != obj2.matrix[i,0])
                {
                    areZeroColumnEquals = false;
                }
            }


            return !areZeroColumnEquals;
        }
        //Количество отрицательных элементов в матрице
        public static explicit operator int(Matrix obj)
        {
            int countMinus = 0;
            for (int i = 0; i < obj.size; i++)
            {
                for (int j = 0; j < obj.size; j++)
                {
                    if(obj.matrix[i, j] < 0)
                    {
                        countMinus++;
                    }
                }
            }


            return countMinus;
        }
        // Конструктор матрицы без параметров
        public Matrix()
        {
            Console.WriteLine("Создание матрицы \n Назовите свою матрицу");
            name = Console.ReadLine();
        }
        public Matrix(string matrName = "default", int razmer = 0)
        {
            size = razmer;
            Console.WriteLine($"Создание матрицы {matrName}");
            name = matrName;
            matrix = new int[size, size];
        }

        private void ChooseSize()
        {
            Console.WriteLine($"Введите размер матрицы {name}");;
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
                    Console.WriteLine($"Введите {j+1} элемент {i+1}строки матрицы {name}");
                    string element = Console.ReadLine();
                    if (element == "")
                    {
                        matrix[i, j] = 0;
                    }
                    else 
                    {
                        matrix[i, j] = Convert.ToInt32(element);
                    }
                }
            }
            WriteMatrix();
        }

        public void WriteMatrix()
        {
            Console.WriteLine($"Матрица {name}:");
            for (int i = 0; i < matrix.Length / matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.Write("\n");
            }

           
        }
        //вложенный объект
       public Production production = new();
        //вложенный класс
        public class Developer
        {
            public string FIO;
            public int ID;
            public int department;
        }

    }

    public class Production
    {
        public int ID;
        public string Name;
    }
}
