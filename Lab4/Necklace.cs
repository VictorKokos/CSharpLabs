using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Necklace
    {
        public Necklace()
        {
            Console.WriteLine("Вот и пустое ожерелье");
        }
        public Necklace(PreciousStones[] array)
        {
            necklace = array;
            Console.WriteLine("Вот и ожерелье");
        }
        public PreciousStones[] necklace = new PreciousStones[0] { };
        public PreciousStones get(int index)
        {
            return necklace[index];
        }

        public void set(PreciousStones stone)
        {
            Array.Resize(ref necklace, necklace.Length + 1);
            necklace[necklace.GetUpperBound(0)] = stone;
        }

        public void del(int n)
        {
             var list = necklace.ToList();
            list.RemoveAt(n);
            necklace = list.ToArray();
        }

        public void Print()
        {
            Console.WriteLine("\n\n\n");
            foreach (var item in necklace)
            {
                Console.WriteLine(item);
            }
        }
    }

    internal class NecklaceController
    {
        public float WeightCount(Necklace necklace)
        {
            float sum = 0;
            foreach (var item in necklace.necklace)
            {
                sum += item.weight;
            }    
            return sum;
        }

        public float PriceCount(Necklace necklace)
        {
            float sum = 0;
            foreach (var item in necklace.necklace)
            {
                sum += item.price;
            }
            return sum;
        }

        public void SortNecklace(Necklace necklace)
        {
            for (int i = 0; i < necklace.necklace.Length; i++)
            {
                for (int j = 0; j < necklace.necklace.Length-1; j++)
                {
                    if (necklace.necklace[j].price < necklace.necklace[j+1].price)
                    {
                        (necklace.necklace[i], necklace.necklace[i+1]) = (necklace.necklace[i+1], necklace.necklace[i]);
                    }
                }
            }
        }

        public void findTransparency(Necklace necklace, double min,double max)
        {
            for (int i = 0; i < necklace.necklace.Length; i++)
            {
                if (necklace.necklace[i].transparency >= min && necklace.necklace[i].transparency <= max)
                {
                    Console.WriteLine(necklace.necklace[i]);
                }
            }
        }
    }

}
