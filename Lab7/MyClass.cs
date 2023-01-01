using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    [Serializable]
    internal class MyClass
    {
        int Id;
        string Value;
        public void setValues(int Id, string Value)
        {
        this.Id = Id;
        this.Value = Value; 
        }

        public override string ToString()
        {
            return $" ID: {Id}, VALUE: {Value}";
        }
    }
}
