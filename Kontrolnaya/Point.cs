using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Kontrolnaya
{
    interface IComparable
    {
        
    }
    class Point : IComparable
    {
        public int x, y, z;

        public Point(int x = 0, int y = 0, int z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Point operator +(Point obj1, Point obj2)
        {
            Point arr = new Point();
            arr.x = obj1.x + obj2.x;
            arr.y = obj1.y + obj2.y;
            arr.z = obj1.z + obj2.z;
            return arr;
        }

        public static Point operator -(Point obj1, Point obj2)
        {
            Point arr = new Point();
            arr.x = obj1.x - obj2.x;
            arr.y = obj1.y - obj2.y;
            arr.z = obj1.z - obj2.z;
            return arr;
        }
    }
}
