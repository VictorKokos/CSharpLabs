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
Console.WriteLine(string.Concat(stringus1, stringus2, stringus3));

stringus3 = string.Copy(stringus1);
Console.WriteLine(string.Concat(stringus1, stringus2, stringus3));

stringus2 = stringus2.Substring(0, 3);
Console.WriteLine(string.Concat(stringus1, stringus2, stringus3));

string[] podstroki = stringus1.Split(' ');
foreach(var pod in podstroki)
{
    Console.WriteLine(pod);
}
stringus3.Insert(0, stringus2);
Console.WriteLine(stringus2);
Console.WriteLine(stringus3);
Console.WriteLine(stringus3.Insert(0, stringus2));