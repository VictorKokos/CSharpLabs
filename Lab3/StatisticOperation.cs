using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public static class StatisticOperation
    {
        public static int Summa (Matrix obj)
        {
            int count = 0;
            for (int i = 0; i < obj.size; i++)
            {
                for (int j = 0; j < obj.size; j++)
                {
                   count = count + obj.matrix[i, j];
                }
            }
            return count;
        }
        public static int Raznica(Matrix obj)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < obj.size; i++)
            {
                for (int j = 0; j < obj.size; j++)
                {
                    if(obj.matrix[i, j] > max)
                        max = obj.matrix[i, j];

                   if(obj.matrix[i, j] < min)
                        min = obj.matrix[i, j];
                }
            }
            int raznica =max - min;
            return raznica;
        }
        public static int KolichestvoElem(Matrix obj)
        {
            int kol = 0;
            for (int i = 0; i < obj.size; i++)
            {
                for (int j = 0; j < obj.size; j++)
                {
                    kol++;
                }
            }
            return kol;
        }
        public static void FirstNumberInStr(this string obj)
        {
           
            string[] slova = obj.Split(' ');
            for (int i = 0; i < slova.Length; i++)
            { 
                if( int.TryParse( slova[i], out int num))
                {
                    Console.WriteLine(num);
                    break;
                }
                
            }
           
        }
        public static void ObnulenieOtricatelnih(this Matrix obj)
        {
            for (int i = 0; i < obj.size; i++)
            {
                for (int j = 0; j < obj.size; j++)
                {
                    if( obj.matrix[i, j] < 0 )
                    {
                        obj.matrix[i, j] = 0;
                    }
                }
            }
        }
    }
}
