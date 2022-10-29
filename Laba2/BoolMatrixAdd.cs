using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    internal partial class BoolMatrix
    {
        public static void ShowInf ()
        {
            Console.WriteLine($"Количество созданных объектов: {kol} ");
            Console.WriteLine($"Количество закрытых вызовов: {PrivateCalls} ");
            Console.WriteLine($"Количество конструкторов: {constructorCount} ");
            Console.WriteLine($"Стандартный размер матрицы: {standartSize} ");

        }

        public override int GetHashCode()
        {
            int k = 0;
            string str = "";
            for(int j = 0; j < 3; j++)
            for (int i = 0; i < 3; i++)
            {
                    str = str+ String.Join("",matrix[j,i]);
            }
            return str.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj is BoolMatrix)
            {
                
                return this.GetHashCode() == obj.GetHashCode();
            }
            return false;
        }
    }
}
