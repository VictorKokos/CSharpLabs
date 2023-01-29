using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Lab4
{
    [Serializable]
    public abstract class Product
    {

        public string Name { get; set; }
        public float Price { get; set; }

    }



    [Serializable]
    public class Stone : Product
    {
        public Stone()
        {
        }
        public Stone(string name, float price, string color)
        {
            Name = name;

            Price = price;

            Color = color;
        }

   
        public string Color { get; set; }
    }
   

}

