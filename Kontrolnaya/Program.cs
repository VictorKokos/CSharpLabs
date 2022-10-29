// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задание 1.А");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(a + b);
Console.WriteLine(str);

Console.WriteLine("Задание 1.Б");
string[,] massStrok = new string[2,4];
massStrok[0, 0] = "Сегодня";
massStrok[0, 1] = "Очень";
massStrok[0, 2] = "Хороший";
massStrok[0, 3] = "День";
massStrok[1, 0] = "Потому";
massStrok[1, 1] = "Что";
massStrok[1, 2] = "Сегодня";
massStrok[1, 3] = "Суббота";

int numberOfInt = 0;
for(int i = 0; i < 2; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.WriteLine(massStrok[i, j]);
        for(int k = 0; k < massStrok[i,j].Length; k++)
        {
            numberOfInt++;
        }
    }
}
Console.WriteLine(numberOfInt);

Console.WriteLine("Задание 2");

Kontrolnaya.Point Point1 = new Kontrolnaya.Point(20, 4, 6);
Kontrolnaya.Point Point2 = new Kontrolnaya.Point(-5, 13, 2);
Console.WriteLine("Координаты первой точки: " +
    Point1.x + " " + Point1.y + " " + Point1.z);
Console.WriteLine("Координаты второй точки: " +
    Point2.x + " " + Point2.y + " " + Point2.z + "\n");

Kontrolnaya.Point Point3 = Point1 + Point2;
Console.WriteLine("\nPoint1 + Point2 = "
    + Point3.x + " " + Point3.y + " " + Point3.z);
Point3 = Point1 - Point2;
Console.WriteLine("\nPoint1 - Point2 = "
    + Point3.x + " " + Point3.y + " " + Point3.z);

Kontrolnaya.Point Point4 = new Kontrolnaya.Point(-5, 13, 2);
Console.WriteLine(Point3.Equals(Point1));

Console.WriteLine(Point4.Equals(Point2));

