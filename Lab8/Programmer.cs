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
            Deleted?.Invoke(list[num]);
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
            if (list.Count > 0)
            {
                foreach (var item in list)
                    Console.WriteLine(item);
            }
            else
            {
                Console.WriteLine("List is empty");
            }
        }
        public void Sortirovka()
        {
            list.Sort();
        }
        public void ClearList()
        {
            list.Clear();
        }

        public void LeftAndRight(string str)
        {
            Console.WriteLine($"слева: {list[list.IndexOf(str) - 1]}," +
                $"Справа : {list[list.IndexOf(str) + 1]}  ");
        }

    }

   



    public class StringProcessing
    {
        public string str;
        public Action action;
        public Func<int, string, string> func;
       public void DelPunctuation ()
        {
            var sb = new StringBuilder();

            foreach (char c in str)
            {
                if (!char.IsPunctuation(c))
                    sb.Append(c);
            }

            str = sb.ToString();
        }
        public string Insert(int num, string inserted)
        {
            str = str.Insert(num, inserted);
            return str;
        }
        public void ToUpperCase() =>
          str = str.ToUpper();

        public void FirstWord () =>
          str = str.Split(' ')[0];
        public void Pad() =>
          str = str.PadLeft(10,'7');
    }
}
