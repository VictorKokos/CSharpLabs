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
            return string.Join("", matrix).GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj is BoolMatrix)
            {
                return base.GetHashCode() == obj.GetHashCode();
            }
            return false;
        }
    }
}
