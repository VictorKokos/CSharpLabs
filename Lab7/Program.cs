using System.IO;
using System.Text;

Lab7.GenericClass<int> intGeneric = new Lab7.GenericClass<int>();
Console.WriteLine("INT");
intGeneric.Add(12);
intGeneric.Add(13);
intGeneric.Show();
intGeneric.Remove(13);
intGeneric.Show();
Lab7.GenericClass<string> stringGeneric = new Lab7.GenericClass<string>();
Console.WriteLine("STRING");
stringGeneric.Add("one");
stringGeneric.Add("two");
stringGeneric.Show();

Console.WriteLine(stringGeneric.Search(0));
Console.WriteLine(stringGeneric.Search(2));


Lab7.GenericClass<double> doubleGeneric = new Lab7.GenericClass<double>();

Console.WriteLine("DOUBLE");
doubleGeneric.Add(43.453); ;
doubleGeneric.Add(7.390);
doubleGeneric.Show();

Console.WriteLine(doubleGeneric.Search(0));
Console.WriteLine(doubleGeneric.Search(2));



Lab7.GenericClass<Lab7.MyClass> myClassGeneric = new Lab7.GenericClass<Lab7.MyClass>();

Lab7.MyClass myClassObj1 = new Lab7.MyClass();
myClassObj1.setValues(1, "This");
Lab7.MyClass myClassObj2 = new Lab7.MyClass();
myClassObj2.setValues(2, "Is");
Lab7.MyClass myClassObj3 = new Lab7.MyClass();
myClassObj3.setValues(3, "My");
Lab7.MyClass myClassObj4 = new Lab7.MyClass();
myClassObj4.setValues(4, "Class");

myClassGeneric.Add(myClassObj1);
myClassGeneric.Add(myClassObj2);
myClassGeneric.Add(myClassObj3);
myClassGeneric.Add(myClassObj4);

myClassGeneric.Show();



myClassGeneric.WriteToBinaryFile(@"d:\MyFile.bin", myClassObj1, true);
Console.WriteLine(myClassGeneric.ReadFromBinaryFile<Lab7.MyClass>(@"d:\MyFile.bin"));






