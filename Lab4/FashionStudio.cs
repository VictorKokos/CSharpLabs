using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public partial class FashionStudio : Product, IClothesRepair
    {
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
