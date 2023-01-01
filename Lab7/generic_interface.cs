using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal interface IGeneric<T>
    {
        void Add(T item);
        void Remove(T item);
        T Search(int num);
        void Show();


    }
}
