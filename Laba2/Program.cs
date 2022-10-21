Console.WriteLine("Hello, World!");


Laba2.BoolMatrix MatrixFunc2 = new Laba2.BoolMatrix("000", "000", "000");
Laba2.BoolMatrix MatrixFunc3 = new Laba2.BoolMatrix("000", "000", "000");
Console.WriteLine(MatrixFunc2.Equals(MatrixFunc3));




Laba2.BoolMatrix MatrixFunc = new Laba2.BoolMatrix();
bool [,] matrix1 = new bool [,] { { true, false, true }, { false, true, false }, { true, true, false } };
bool[,] matrix2 = new bool[,] { { false, false, false }, { true, true, true }, { true, false, false } };
Console.WriteLine("Матрица 1: ");
for (int i = 0; i < matrix1.Length / matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(0); j++)
    {
        Console.Write($"{matrix1[i, j]} \t");
    }
    Console.Write("\n");
}
Console.WriteLine("Матрица 2: ");
for (int i = 0; i < matrix1.Length / matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(0); j++)
    {
        Console.Write($"{matrix2[i, j]} \t");
    }
    Console.Write("\n");
}
bool[,] matrix3 = MatrixFunc.SumMatrix(matrix1, matrix2);
Console.WriteLine("Логическая сумма: ");
for (int i = 0; i < matrix1.Length / matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(0) ; j++)
    {
        Console.Write($"{matrix3[i, j]} \t");
    }
    Console.Write("\n");
}
bool[,] matrix4 = MatrixFunc.MultipltyMatrix(matrix1, matrix2);
Console.WriteLine("Логическое произведение: ");
for (int i = 0; i < matrix1.Length / matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(0); j++)
    {
        Console.Write($"{matrix4[i, j]} \t");
    }
    Console.Write("\n");
}

bool[,] matrix5 = MatrixFunc.Inversion(matrix1);
Console.WriteLine("Инверсия матрицы 1: ");
for (int i = 0; i < matrix1.Length / matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(0); j++)
    {
        Console.Write($"{matrix5[i, j]} \t");
    }
    Console.Write("\n");
}

Laba2.BoolMatrix MatrixObj1 = new Laba2.BoolMatrix();
MatrixObj1.matrix = new bool[3, 3] { { true, false, true }, { false, true, false }, { true, true, false } };
Laba2.BoolMatrix MatrixObj2 = new Laba2.BoolMatrix();
MatrixObj2.matrix = new bool[3, 3] { { false, true, true }, { true, false, true }, { true, false, false } };
Laba2.BoolMatrix MatrixObj3 = new Laba2.BoolMatrix();
MatrixObj3.matrix = new bool[3, 3] { { true, true, true }, { true, true, false }, { true, true, false } };
Laba2.BoolMatrix MatrixObj4 = new Laba2.BoolMatrix();
MatrixObj4.matrix = new bool[3, 3] { { false, false, false }, { false, true, false }, { false, true, false } };
Laba2.BoolMatrix MatrixObj5 = new Laba2.BoolMatrix();
MatrixObj5.matrix = new bool[3, 3] { { false, false, true }, { true, false, false }, { true, true, false } };
Laba2.BoolMatrix MatrixObj6 = new Laba2.BoolMatrix();
MatrixObj6.matrix = new bool[3, 3] { { false, true, false }, { true, false, false }, { true, false, false } };
Laba2.BoolMatrix MatrixObj7 = new Laba2.BoolMatrix();
MatrixObj7.matrix = new bool[3, 3] { { true, true, false }, { true, false, true }, { false, true, true } };

Laba2.BoolMatrix[] MassivObjectov = { MatrixObj1, MatrixObj2, MatrixObj3, MatrixObj4, MatrixObj5, MatrixObj6, MatrixObj7 };
int min = 9;
int max = 0;
Laba2.BoolMatrix MatrixMin = new();
Laba2.BoolMatrix MatrixMax = new();
for (int i = 0; i < MassivObjectov.Length; i++)
{
    if(MassivObjectov[i].Count1() < min)
    {
        MatrixMin = MassivObjectov[i];
        min = MassivObjectov[i].Count1();
    }
    if (MassivObjectov[i].Count1() > max)
    {
        MatrixMax = MassivObjectov[i];
        max = MassivObjectov[i].Count1();
    }
}
Console.WriteLine("Матрица с наименьшим количеством единиц");
for (int i = 0; i < MatrixMin.matrix.Length / MatrixMin.matrix.GetLength(0); i++)
{
    for (int j = 0; j < MatrixMin.matrix.GetLength(0); j++)
    {
        Console.Write($"{MatrixMin.matrix[i, j]} \t");
    }
    Console.Write("\n");
}
Console.WriteLine("Матрица с наибольшим количеством единиц");
for (int i = 0; i < MatrixMax.matrix.Length / MatrixMax.matrix.GetLength(0); i++)
{
    for (int j = 0; j < MatrixMax.matrix.GetLength(0); j++)
    {
        Console.Write($"{MatrixMax.matrix[i, j]} \t");
    }
    Console.Write("\n");
}
int simbol = Convert.ToInt32(Console.ReadLine());
if (simbol == 1 || simbol == 0)
{
    Laba2.BoolMatrix[] sameAmountArray = {null, null, null, null, null, null, null };
    for (int i = 0; i < MassivObjectov.Length; i++)
    {
        int countInStr = 0;
        int compareTo = -10;
        bool areSame = false;
      for(int j = 0; j<MatrixObj1.matrix.Length  / MatrixObj1.matrix.GetLength(0); j++)
        {
            for(int k = 0; k < MatrixObj1.matrix.GetLength(0); k++)
            {
              if(  MassivObjectov[i].matrix[j,k] == true )
                {
                    countInStr++;
                }
            }
            if (j > 0)
            {
                if(compareTo != countInStr)
                {
                    areSame = false; break;
                }
            }
            compareTo = countInStr;
            areSame = true;
            countInStr = 0;
        }
      if(areSame)
        {
            sameAmountArray[i] =MassivObjectov[i];
        }
    }


    for (int k = 0; k < MassivObjectov.Length; k++)
    {
        if (sameAmountArray[k] != null)
        {
            for (int i = 0; i < MatrixMax.matrix.Length / MatrixMax.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < MatrixMax.matrix.GetLength(0); j++)
                {
                    Console.Write($"{sameAmountArray[k].matrix[i, j]} \t");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }

    Console.WriteLine("Введите первую строку матрицы.");
    string stroka1 = Console.ReadLine();
    Console.WriteLine("Введите вторую строку матрицы.");
    string stroka2 = Console.ReadLine();
    Console.WriteLine("Введите третью строку матрицы.");
    string stroka3 = Console.ReadLine();

    Laba2.BoolMatrix MatrixObj8 = new Laba2.BoolMatrix(stroka1, stroka2, stroka3);

    MatrixObj8.WriteMatrix();
    Laba2.BoolMatrix MatrixObj9 = new Laba2.BoolMatrix(2);
    MatrixObj9.WriteMatrix();
    string example = "000";

    MatrixObj9.RevertStr(ref example);
    Console.WriteLine(example);
    Laba2.BoolMatrix.ShowInf();
}
