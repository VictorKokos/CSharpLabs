/*
//Создаём, определяем размер, заполняем матрицы 1 и 2

Lab3.Matrix Matrica1 = new();


Matrica1.FillMatrix();

Lab3.Matrix Matrica2 = new();
Matrica2.FillMatrix();

//Создаем матрицу 3 - сумму матриц 1 и 2
Lab3.Matrix Matrica3 = Matrica1 + Matrica2; 
Matrica3.WriteMatrix();
// обнуляем матрицу 3
Matrica3= -(Matrica3);
Matrica3.WriteMatrix();

*/
// матрицы 4 и 5 не равны по первому столбцу

Lab3.Matrix Matrica4 = new("4 матрица", 3);
Lab3.Matrix Matrica5 = new("5 матрица", 3);

Matrica4.matrix = new int[3, 3] { { 0, 2, 5 }, { 34, -2, -5 }, { 0, 56, 5 } };
Matrica5.matrix = new int[3, 3] { { 45, 26, 25 }, { 3, 2, 5 }, { 30, 6, 55 } };

if(Matrica4 == Matrica5)
{
    Console.WriteLine("Матрицы 4 и 5 равны по первому столбцу");
}
else
{
    Console.WriteLine("Матрицы 4 и 5 не равны по первому столбцу");
}

// матрицы 6 и 7 равны по первому столбцу
Lab3.Matrix Matrica6 = new("6 матрица", 3);
Lab3.Matrix Matrica7 = new("7 матрица", 3);

Matrica6.matrix = new int[3, 3] { { 0, -2, 5 }, { 4, -2, 0 }, { 0, 0, -25 } };
Matrica7.matrix = new int[3, 3] { { 0, 2, 5 }, { 4, -5, -5 }, { 0, 26, 5 } };

if (Matrica6 == Matrica7)
{
    Console.WriteLine("Матрицы 4 и 5 равны по первому столбцу");
}
else
{
    Console.WriteLine("Матрицы 6 и 7 не равны по первому столбцу");
}

//Подсчет количества отрицательных элементов
Console.WriteLine("Количество отрицательных элементов в 5, 6, 7 матрицах");
Console.WriteLine((int) Matrica5 +"\n");
Console.WriteLine((int)Matrica6 + "\n");
Console.WriteLine((int)Matrica7 + "\n");


//Инициализация вложенного объекта

Matrica7.production.ID = 0;
Matrica7.production.Name = "VkusnoITochka";

Console.WriteLine($"ID= {Matrica7.production.ID} \n Name = {Matrica7.production.Name}" );


//Инициализация вложенного класса
Lab3.Matrix.Developer Sasha = new Lab3.Matrix.Developer();
Sasha.FIO = "Kuchkov Alexander Sergeevich";
Sasha.ID = 134;
Sasha.department = 24;

Console.WriteLine($"\n \n ID= {Sasha.ID} \n FIO = {Sasha.FIO} \n DEP = {Sasha.department}");


//Статические методы
Console.WriteLine(Lab3.StatisticOperation.Summa(Matrica5));
Console.WriteLine(Lab3.StatisticOperation.Raznica(Matrica6));
Console.WriteLine(Lab3.StatisticOperation.KolichestvoElem(Matrica7));

//Методы расширения
Console.WriteLine("Первое число в строке: ");
Console.WriteLine("string a = ddwfr fr 30 22" );
    Console.WriteLine("string b = 54394 hewfe hfbw");
string a = "d40dwfr fr 30 22";
string b = "54394 hewfe hfbw";
Lab3.StatisticOperation.FirstNumberInStr(a);

Lab3.StatisticOperation.FirstNumberInStr(b);
Console.WriteLine("Обнуление отрицательных элементов матрицы");
Matrica7.WriteMatrix();
Lab3.StatisticOperation.ObnulenieOtricatelnih(Matrica7);
Matrica7.WriteMatrix();
