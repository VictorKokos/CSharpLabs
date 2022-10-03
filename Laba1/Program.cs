using System.Text;
//1.a) 
Console.WriteLine("Задание 1a?");
if (Console.ReadLine() != "0")
{
    bool a = Convert.ToBoolean(Console.ReadLine());
    Console.WriteLine(a);

    byte b = Convert.ToByte(Console.ReadLine());
    Console.WriteLine(b);

    sbyte c = Convert.ToSByte(Console.ReadLine());
    Console.WriteLine(c);

    sbyte d = Convert.ToSByte(Console.ReadLine());
    Console.WriteLine(d);

    char e = Convert.ToChar(Console.ReadLine());
    Console.WriteLine(e);

    decimal f = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine(f);

    double g = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(g);

    float h = (float)Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(h);

    int i = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(i);

    uint j = Convert.ToUInt32(Console.ReadLine());
    Console.WriteLine(j);

    nint k = (nint)Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(k);

    nuint l = (nuint)Convert.ToUInt32(Console.ReadLine());
    Console.WriteLine(l);

    long m = Convert.ToInt64(Console.ReadLine());
    Console.WriteLine(m);

    ulong n = Convert.ToUInt64(Console.ReadLine());
    Console.WriteLine(n);

    short o = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine(o);

    ushort p = Convert.ToUInt16(Console.ReadLine());
    Console.WriteLine(p);

}

//1.b) 
int num = 6;
long num2 = num;

byte but = 144;
short butButShort = but;
int shortButInt = butButShort;
long intButLong = shortButInt;

ushort shorti = 34;
uint shtani = shorti;
ulong shtaniDlinnie = shtani;

int celoe = 70;
float neCeloe = (float)celoe;
double tozheNeCeloe = (double)neCeloe;

string Name = "Gosha";
char gasf = Convert.ToChar(Name[0]);

int intGasf = Convert.ToInt32(gasf);
short shortGasf = Convert.ToInt16(intGasf);
long longGasf = Convert.ToInt64(shortGasf);

//1.c)
int someNumber = 14;
object upakovka = someNumber;
int otherNumber = (int)upakovka;

double someDouble = 253.325;
upakovka = someDouble;
double otherDouble = (double) upakovka;

char someChar = 'c';
upakovka = someChar;
char otherChar = (char)upakovka;

bool someBool = true;
upakovka = someBool;
bool otherBool = (bool)upakovka;

// 1d
var z = 5;
var v = "ajshashasas";
Console.WriteLine(z.GetType());

// 1e

int? someInt1 = null;
int? someInt2 = 34;
Console.WriteLine(someInt1.HasValue);
Console.WriteLine(someInt2.HasValue);

//1f
var x = 14;
//x = 14.88;

//2a
string str1 = "go";
string str2 = "neGo";
Console.WriteLine(str1 == str2 ? "same" : "neSame");

//2b
string stringus1 = "big russian floppa";
string stringus2 = "is not a cat";
string stringus3 = "it is a caracal";
//Сцепление
Console.WriteLine(string.Concat(stringus1, stringus2, stringus3));
//Копирование
stringus3 = string.Copy(stringus1);
Console.WriteLine(string.Concat(stringus1, stringus2, stringus3));
//Выделение подстроки
stringus2 = stringus2.Substring(0, 3);
Console.WriteLine(string.Concat(stringus1, stringus2, stringus3));
//Разделение на слова
string[] podstroki = stringus1.Split(' ');
foreach(var pod in podstroki)
{
    Console.WriteLine(pod);
}
//Вставка подстроки в заданную позицию
Console.WriteLine(stringus3.Insert(0, stringus2.Substring(0, 3)));
//Удаление подстроки
Console.WriteLine(stringus3.Remove(0, 4));

Console.WriteLine($"{stringus1} likes pelmeni");
//2c
string stringus4 = "";
string stringus5 = null;
Console.WriteLine(string.IsNullOrEmpty(stringus4));
Console.WriteLine(string.IsNullOrEmpty(stringus5));
//2d
StringBuilder sb = new StringBuilder("NewYork", 50);
Console.WriteLine(sb);
sb.Remove(0, 3);
Console.WriteLine(sb);
sb.Insert(0, "100");
sb.Insert(sb.Length, "200");
Console.WriteLine(sb);
Console.WriteLine("3 Task?");
int three = Convert.ToInt32(Console.ReadLine());
if (three != 0)
{
    //3a
    int[,] matrix = { { 1, 2, 3, }, { 4, 5, 6 }, { 6, 7, 8 }, { 8, 9, 10 } };
    for (int i = 0; i < 4; i++)
    {
        for (int k = 0; k < 3; k++)
        {
            Console.Write($"{matrix[i, k].ToString()}\t");
        }
        Console.Write("\n");
    }
    //3b
    string[] strochki = { "wwff df fdf", "sdfwevss dvsd df", "sdvsd xvdxse d" };
    for (int i = 0; i < strochki.Length; i++)
    {
        Console.WriteLine(strochki[i]);
    }
    Console.WriteLine(strochki.Length);
    Console.WriteLine("Введите позицию");
    int pos = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите новую строку");
    string newText = Console.ReadLine();
    strochki[pos] = newText;
    for (int i = 0; i < strochki.Length; i++)
    {
        Console.WriteLine(strochki[i]);
    }
    //3c
    double[][] stupench = new double[3][];
    stupench[0] = new double[2];
    stupench[1] = new double[3];
    stupench[2] = new double[4];
    for (int i = 0; i < stupench[0].Length; i++)
        stupench[0][i] = Convert.ToDouble(Console.ReadLine());
    for (int i = 0; i < stupench[1].Length; i++)
        stupench[1][i] = Convert.ToDouble(Console.ReadLine());
    for (int i = 0; i < stupench[2].Length; i++)
        stupench[2][i] = Convert.ToDouble(Console.ReadLine());

    for (int i = 0; i < stupench[0].Length; i++)
        Console.Write($"{stupench[0][i]} \t");
    Console.Write("\n");
    for (int i = 0; i < stupench[1].Length; i++)
        Console.Write($"{stupench[1][i]} \t");
    Console.Write("\n");
    for (int i = 0; i < stupench[2].Length; i++)
        Console.Write($"{stupench[2][i]} \t");
    Console.Write("\n");

    var neyavniMassiv = new[] { 1, 2, 3, };
    var neyavnayaStroka = "sdwe";

    Console.WriteLine(neyavniMassiv[0]);
    Console.WriteLine(neyavnayaStroka);
}
//4a

var kort1 = (1, "32d", 'w', "sdcdfff", 18446744073709551613);

//4b

Console.WriteLine(kort1);
Console.WriteLine(kort1.Item1);
Console.WriteLine(kort1.Item3);
Console.WriteLine(kort1.Item4);
int kortVar = kort1.Item1;
Console.WriteLine(kortVar);
(string slov, char simbolw) = (kort1.Item2, kort1.Item3);
Console.WriteLine(slov);
Console.WriteLine(simbolw);
(var elem4, var elem5) = (kort1.Item4, kort1.Item5);
Console.WriteLine(elem4);
Console.WriteLine(elem5);

var kort2 = (1, "32d", 'w', "sdcdfff", 18446744073709551613);

if(kort1 == kort2)
{
    Console.WriteLine("kort1 = kort2");
}
//5
int[] Celie5 = { 1, 2, 3, 4, 5, 6, };
string Stroka5 = "scuf";
 (int, int, int, char) Func(int[] Mass,string Stroka)
{
  int maxim = Mass.Max();
  int minim = Mass.Min();
  int summa = Mass.Sum();
    char firstFromTask5 = Stroka.First();

    return (maxim, minim, summa, firstFromTask5);
}
Console.WriteLine(Func(Celie5, Stroka5));
//6
int Func1 ()
{
    checked
    {
        int maxVozmozh = int.MaxValue;
        return maxVozmozh;
    }
    
}
int Func2()
{
    unchecked
    {
        int maxVozmozh = int.MaxValue + 1;
        return maxVozmozh;
    }
}
Console.WriteLine(Func1());
Console.WriteLine(Func2());
