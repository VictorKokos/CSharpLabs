using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab4
{
    internal class NumberIsLessThanZero : Exception
    {
        public NumberIsLessThanZero() : base()
        {
            Console.WriteLine("Число меньше 0");
        }
        public void PrintHigher()
        {
            Console.WriteLine("Напишите большее число");
        }
    }
    internal class NullException : NullReferenceException
    {
        public NullException() 
        {
            Console.WriteLine("Объект является null");
        }
    }

    public class ThisCollectionList<T> : List<T>
    {
        List<T> ?list = new();
        public void AddList (T item)
        {
            list.Add (item);
        }

        public bool SearchList(T item)
        {
           return list.Contains(item);
        }

    }
    
}
