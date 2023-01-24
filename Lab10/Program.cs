
using Lab10;
using System.Linq;

object[] values = new object[] { "June", "July", "May",
"December", "January", "February", "April", "March", "September",
"October", "November", "August"  };
Console.WriteLine("Выберите количество символов");
int kol = Convert.ToInt32(Console.ReadLine());
IEnumerable<string> strings = values.OfType<string>().Where(i => i.Length == kol);

foreach(string s in strings)
Console.WriteLine(s);

Console.WriteLine("//");
IEnumerable<string> strings2 = values.OfType<string>().Where(i => 
i == "June" || i == "July" || i == "August" ||
i == "January" || i == "February" || i == "December");

foreach (string s in strings2)
    Console.WriteLine(s);
Console.WriteLine("//");


IEnumerable<string> strings3 = values.OfType<string>().OrderBy(i => i);



foreach (string s in strings3)
    Console.WriteLine(s);
Console.WriteLine("//");


IEnumerable<string> strings4 = values.OfType<string>().Where(i => i.Contains("u"));

foreach (string s in strings4)
    Console.WriteLine(s);
Console.WriteLine("//");


IEnumerable<string> strings5 = values.OfType<string>().Where(i => i.Length >=4);

foreach (string s in strings5)
    Console.WriteLine(s);
Console.WriteLine("//");

//Task2




BoolMatrix bool1 = new BoolMatrix(2);
BoolMatrix bool2 = new BoolMatrix(2);
BoolMatrix bool3 = new BoolMatrix(2);
BoolMatrix bool4 = new BoolMatrix(2);
BoolMatrix bool5 = new BoolMatrix(2);
BoolMatrix bool6 = new BoolMatrix(3);
BoolMatrix bool7 = new BoolMatrix(4);
BoolMatrix bool8 = new BoolMatrix(3);
BoolMatrix bool9 = new BoolMatrix(3);
BoolMatrix bool10 = new BoolMatrix(3);


List<BoolMatrix> bools = new List<BoolMatrix>();
bools.Add(bool1);
bools.Add(bool2);
bools.Add(bool3);
bools.Add(bool4);
bools.Add(bool5);
bools.Add(bool6);
bools.Add(bool7);
bools.Add(bool8);
bools.Add(bool9);
bools.Add(bool10);

for(int i = 0; i<10; i++)
{
    bools[i].WriteMatrix();
}


IEnumerable<BoolMatrix> boolsEnum1 = bools.OrderBy(i => i.Count1());
BoolMatrix maxOne = boolsEnum1.Last();
BoolMatrix minOne = boolsEnum1.First();
Console.WriteLine("MAX");
maxOne.WriteMatrix();
Console.WriteLine("MIN");
minOne.WriteMatrix();

IEnumerable<BoolMatrix> boolsEnum2 = bools.Where(i => i.areEqualSymbols() == true);
Console.WriteLine("SAME IN 1 STRING");
foreach (var s in boolsEnum2)
{
    s.WriteMatrix();
}
Console.WriteLine("MAX SIZE");
IEnumerable<BoolMatrix> boolsEnum3 = bools.OrderBy(i => i.MatrixSize);
BoolMatrix maxSize = boolsEnum3.Last();
maxSize.WriteMatrix();


Console.WriteLine("Выберите размер");
int size = Convert.ToInt32(Console.ReadLine());

int kolvo = bools.Where(i => i.MatrixSize == size).Count();

Console.WriteLine($"Количество матриц заданного размера: {kolvo}") ;

Console.WriteLine("Упорядоченный список матриц по количеству единиц ");
foreach (var s in boolsEnum1)
{
    s.WriteMatrix();
}

float average = (float)bools.Where(m => m.MatrixSize == 3).Reverse().Distinct().Skip(1).Average(m => m.Count1());
Console.WriteLine(average);


BoolMatrix bool11 = new BoolMatrix(2);
BoolMatrix bool12 = new BoolMatrix(2);
BoolMatrix bool13 = new BoolMatrix(2);
BoolMatrix bool14 = new BoolMatrix(2);
BoolMatrix bool15 = new BoolMatrix(2);

List<BoolMatrix> bools2 = new List<BoolMatrix>();
bools2.Add(bool11);
bools2.Add(bool12);


var join = bools.Join(bools2, c => c.MatrixSize, d => d.MatrixSize, (c,d) => d.MatrixSize);

foreach (var s in join)
    Console.WriteLine(s);