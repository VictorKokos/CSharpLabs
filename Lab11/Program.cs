using Lab9;
using Lab7;
using Lab11;
using System.Reflection;

Image image = new Image();
MyClass myObj = new MyClass();

Type MyType = typeof(Image);
MethodInfo method = MyType.GetMethod("SetInf");
Reflector.GetAssembly(MyType);

Reflector.AreThereConstructors(MyType);

Reflector.PublicMethods(MyType);

Reflector.Fields(MyType);

Reflector.Interfaces(MyType);

Reflector.TypeOfParameter(MyType);

Reflector.Invoke(MyType, method);

MyType = typeof(MyClass);

Reflector.GetAssembly(MyType);

Reflector.AreThereConstructors(MyType);

Reflector.PublicMethods(MyType);

Reflector.Fields(MyType);

Reflector.Interfaces(MyType);


MyType = typeof(int);

Reflector.GetAssembly(MyType);

Reflector.AreThereConstructors(MyType);

Reflector.PublicMethods(MyType);

Reflector.Fields(MyType);

Reflector.Interfaces(MyType);

MyType = typeof(Image);


Console.WriteLine(Reflector.Create(MyType));



