using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal interface ICollectionType
    {
        void Add(Type type);
        void Remove(Type type);
        void View (Type type);
    }
}
