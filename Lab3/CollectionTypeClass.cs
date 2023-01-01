using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class CollectionTypeClass<T> : ICollection<T>
    {
        ICollection<Matrix> ?MatrixCollection;

    }


public interface ICollection<T> : IEnumerable<T>
    {
       void Add(T item);
        void Delete(int i);
        void View();
    }
}
