using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{


    public class Programmer
    {

        List<string> list = new List<string>(10);
        public delegate void Delete(string str);

        public delegate void Mutate();
        public event Delete Deleted;
        public event Mutate Mutated;


       public void AddItem(string str) => list.Add(str);
        public void DeleteItem(int num)
        {
            Deleted?.Invoke($"Удалён элемент {list[num]} ");
            list.RemoveAt(num);
           
        }

        public void Replace(int num, string str)
        {
            list.Insert(num,str);

           

            Mutated?.Invoke();
           

        }

        public void DisplayMessage(string message) => Console.WriteLine(message);
        public void DisplayAll()
        {
            foreach(var item in list)
            Console.WriteLine(item);
        }
        public void Sortirovka()
        {
            list.Sort();
        }

    }

   
}
