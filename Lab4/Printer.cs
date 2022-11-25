using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Printer
    {
        public virtual void IAmPrinting(Product product)
        {
           Console.WriteLine( product.GetType());
          Console.WriteLine(  product.ToString());
        }
    }
}
