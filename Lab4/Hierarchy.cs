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
    }
    sealed public class Thread : Product
    {
      public float lenth;
      public string color;
     public override void PrintInfo()
        {
            Console.WriteLine($"{name}, стоимость: {price}, длина: {lenth}");
        }
    }
    public class  Stones: Product
    {
      public float weight;
      public string color;

        public override void PrintInfo()
        {
            Console.WriteLine($"{name}, стоимость: {price}, масса: {weight}");
        }
        public virtual void BuyStone()
        {
            Console.WriteLine("Камень куплен");
        }
    }
    public class PreciousStones : Stones
    {
       
        public int OrderOfJewel;
    }
    public class SemiPreciousStones : Stones
    {
        public int OrderOfSemiJewel;

    }
   sealed public class Ruby : PreciousStones
    {
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
        public override string ToString()
        {
            return name;
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
    public class FashionStudio : Product, IClothesRepair
    {
        public int numberOfEmployees;
        public override void PrintInfo()
        {
            Console.WriteLine($"{name}, стоимость: {price}, Количество сотрудникоы: {numberOfEmployees}");
        }
        public void UnwindThread(Thread thread)
        {
            thread.lenth--;
        }
        public void Repair(Clothes clothes)
        {
            clothes.wear = 0;
        }
    }

}
