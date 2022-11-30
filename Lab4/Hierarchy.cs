using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
 
    public abstract class Product
    {
        public string name;
        public float price;
        public abstract void PrintInfo();
        public override string ToString()
        {
            return ($"Тип: {this.GetType()}, имя: {name}, стоимость: {price},");
        }
        public enum type
        {
            clothing,
            jewerly
        }
    }
    sealed public class Thread : Product
    {
        public Thread ()
        {
            Console.WriteLine(type.clothing);
        }
      public float lenth;
      public string color;
     public override void PrintInfo()
        {
            Console.WriteLine($"Тип: {this.GetType()}, имя: {name}, стоимость: {price}, длина: {lenth}");
        }
        public override string ToString()
        {
            return ($"Тип: {this.GetType()}, имя: {name}, стоимость: {price}, длина: {lenth}, цвет: {color}");
        }
    }
    public class  Stones: Product
    {
      public float weight;
      public string color;

        public override void PrintInfo()
        {
            Console.WriteLine($"Тип: {this.GetType()}, имя: {name}, стоимость: {price}, масса: {weight}");
        }
        public virtual void BuyStone()
        {
            Console.WriteLine("Камень куплен");
        }
        public override string ToString()
        {
            return ($"Тип: {this.GetType()}, имя: {name}, стоимость: {price}, вес: {weight}, цвет: {color}");
        }
    }
    public class PreciousStones : Stones
    {
        public PreciousStones()
        {
            Console.WriteLine(type.jewerly);
        }
        public double transparency;
        public int OrderOfJewel;
        public override string ToString()
        {
            return ($"Тип: {this.GetType()}, имя: {name}, стоимость: " +
                $"{price}, вес: {weight}, цвет: {color}, степень: {OrderOfJewel}, Прозрачность: {transparency}");
        }
    }
    public class SemiPreciousStones : Stones
    {
        public int OrderOfSemiJewel;
        public override string ToString()
        {
            return ($"Тип: {this.GetType()}, имя: {name}, стоимость: {price}, вес: {weight}, цвет: {color}");
        }

    }
   sealed public class Ruby : PreciousStones
    {
        float transparency;
        public override void BuyStone()
        {
            Console.WriteLine("Рубин куплен");
        }
        public Ruby()
        {



            OrderOfJewel = 1;
            color = "red";

         
    }
    }
   sealed public class Diamond : PreciousStones
    {
        public override void BuyStone()
        {
            Console.WriteLine("Алмаз теперь мой");
        }
        public Diamond()
        {
            OrderOfJewel = 1;
            color = "blue";
        }
    }
    sealed public class Emerald : PreciousStones
    {

        public override void BuyStone()
        {
            Console.WriteLine("Изумруд блестит в моих руках. Теперь он мой.");
        }
        public Emerald()
        {
            OrderOfJewel = 1;
            color = "green";
        }
       
        public override int GetHashCode()
        {
            return name.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
           if (obj is Emerald emerald) return (name == emerald.name);
            return false;
        }
    }

    public class Clothes : Product
    {
        public int wear;
        public override void PrintInfo()
        {
            Console.WriteLine($"{name}, стоимость: {price}, износ: {wear}");
        }
    }
    public interface IClothesRepair
    {
        public void UnwindThread (Thread thread);
        public void Repair(Clothes clothes);
        public void PrintInfo();
    }
     public partial class FashionStudio : Product, IClothesRepair
    {
        struct Employee
        {
            string CEO;
            string[] workers;
        }
        public int numberOfEmployees;
        public override void PrintInfo()
        {
            Console.WriteLine($"{name}, стоимость: {price}, Количество сотрудникоы: {numberOfEmployees}");
        }
       
    }

}
