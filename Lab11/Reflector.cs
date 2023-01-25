
using Lab9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    public static class Reflector
    {
        public static void  GetAssembly(Type type)
        {
            string path = @$"d:\Work\CSharpLabs\Lab11\{type.Name}.txt";

            string AssemblyInf = type.Assembly.FullName;
     
        
             File.AppendAllText(path, $"\n{AssemblyInf}");
          
        }

        public static void AreThereConstructors(Type type)
        {
            string path = @$"d:\Work\CSharpLabs\Lab11\{type.Name}.txt";

            bool areConstr = Convert.ToBoolean(type.GetConstructors().Length);
            

            File.AppendAllText(path, $"\n Конструкторы: {areConstr.ToString()}");

        }

        public static IEnumerable<string> PublicMethods(Type type)
        {
            string path = @$"d:\Work\CSharpLabs\Lab11\{type.Name}.txt";
            MethodInfo[] methodInfo = type.GetMethods();

            IEnumerable<string> methods = methodInfo.Select(m => m.Name);
                  File.AppendAllText(path, $"\n Методы:");
            foreach (MethodInfo method in methodInfo)
            {
                File.AppendAllText(path, $"{method}, ");
              
            }
            return methods;

        }

        public static void Fields(Type type)
        {
            string path = @$"d:\Work\CSharpLabs\Lab11\{type.Name}.txt";

            MemberInfo[] fieldInfo = type.GetMembers();

             File.AppendAllText(path, $"\n Поля:");
            foreach (MemberInfo field in fieldInfo)
            {
                 File.AppendAllText(path, $"{field.Name}, ");
               
            }
            

        }

        public static void Interfaces(Type type)
        {
            string path = @$"d:\Work\CSharpLabs\Lab11\{type.Name}.txt";

            MemberInfo[] fieldInfo = type.GetInterfaces();

            File.AppendAllText(path, $"\n Интерфейсы:");
            foreach (MemberInfo field in fieldInfo)
            {
                File.AppendAllText(path, $"{field.Name}, ");

            }


        }
        public static void TypeOfParameter(Type type)
        {
            string path = @$"d:\Work\CSharpLabs\Lab11\{type.Name}.txt";
            string param = Console.ReadLine();
            Type typeOfParam = typeof(int);
            switch(param)
            {
                case "int":
                    {
                        typeOfParam = typeof(int);
                        break;
                    }
                  case "string":
                    {
                        typeOfParam= typeof(string);
                        break;
                    }
            }
            MethodInfo[] fieldInfo = (MethodInfo[])type.GetMethods() ;

            File.AppendAllText(path, $"\n Методы с параметрами определённого типа:");
            foreach (MethodInfo field in fieldInfo)
            {
                File.AppendAllText(path, $"{field.Name}, ");

            }


        }
        public static void Invoke(Type type, MethodInfo method)
        {
            Image image = new Image();
            List<object> args = new List<object>() { "dd", 200, 200 } ;
            method.Invoke(image, args.ToArray());
            Console.WriteLine(image.ToString());
        }
        public static object Create (Type type )
        {
            Type[] types = new Type[3];
            types[0] = typeof(string);
            types[1] = typeof(int);
            types[2] = typeof(int);

            List<object> args = new List<object>() { "ssss", 600, 400 };
            ConstructorInfo constructor = type.GetConstructor(BindingFlags.Instance | BindingFlags.Public, null,
                CallingConventions.HasThis, types, null);
            
            return constructor.Invoke(args.ToArray());
        }
    }
}
