using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab14
{

    public class Threads
    {
        static Mutex mutex = new Mutex();
        object locker = new object();

        public int n = 0;

        public void CalculateSimple()
        {

            for (int i = 1; i < n; i++)
            {
                bool isSimple = false;
                int m = 2;
                while (m < i)
                {

                    if (i % m == 0)
                    {
                        isSimple = true;
                        break;
                    }
                    m++;
                }
                if (!isSimple)
                {
                    Console.Write($"{i}, ");
                    using (StreamWriter sw = new StreamWriter(@"D:\Work\CSharpLabs\Lab14\Simple.txt", true))
                    {
                        sw.Write($"{i}, ");
                    }
                }
            }
        }
        public void Chet()
        {
            //lock(locker)
            //{ 
            //mutex.WaitOne();

            for (int i = 1; i < n; i++)
            {

                Thread.Sleep(30);
                if (i % 2 == 0)
                {
                    Console.Write($"{i}, ");
                    FileStreamOptions fileStreamOptions = new FileStreamOptions();
                    fileStreamOptions.Share = FileShare.Write;
                    fileStreamOptions.Mode = FileMode.Append;
                    fileStreamOptions.Access = FileAccess.Write;
                    using (StreamWriter sw = new StreamWriter(@"D:\Work\CSharpLabs\Lab14\ChetNechet.txt", fileStreamOptions))
                    {
                        sw.Write($"{i}, ");
                    }
                }

            }
            //}
            //mutex.ReleaseMutex();
        }
        public void NeChet()
        {

            //lock (locker)
            //{
            //mutex.WaitOne();
            for (int i = 1; i < n; i++)
            {
                Thread.Sleep(100);

                if (i % 2 == 1)
                {
                    Console.Write($"{i}, ");
                    FileStreamOptions fileStreamOptions = new FileStreamOptions();
                    fileStreamOptions.Share = FileShare.Write;
                    fileStreamOptions.Mode = FileMode.Append;
                    fileStreamOptions.Access = FileAccess.Write;
                    using (StreamWriter sw = new StreamWriter(@"D:\Work\CSharpLabs\Lab14\ChetNechet.txt", fileStreamOptions))
                    {
                        sw.Write($"{i}, ");
                    }
                }

            }
            //}
            //mutex.ReleaseMutex();
        }
        public void Repeating(object obj)
        {
                Random random = new Random();
                int r = random.Next(1, 1000);
                Console.Write($"RAND {r} ");
        }
    }
}
    
     
