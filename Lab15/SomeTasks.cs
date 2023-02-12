using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    public static class SomeTasks
    {
        public static int n;
       public static int[] array = new int[10000];

        public static void PlusArray(int num)
        {

            array[num] = num;
            Console.WriteLine(num);

        }
        public async static void Continue(Task t)
        {
            Console.WriteLine($"Id задачи: {Task.CurrentId}");
            Console.WriteLine($"Id предыдущей задачи: {t.Id}");
            Thread.Sleep(3000);
        }
        public async static Task<int> SquareAsync(int n)
        {
            await Task.Delay(0);
            int m = n * n;
            Console.WriteLine(m);
            return m;
        }
        public async static Task<int> DelenieAsync(int n)
        {
            await Task.Delay(0);
            int m = n / 123;
            Console.WriteLine(m);
            return m;
        }

        public async static Task<int> UmnozhAsync(int n)
        {
            await Task.Delay(0);
            int m = n * 5673;
            Console.WriteLine(m);

            return m;
        }
        public async static Task AllAsync(Task a, Task b, Task c)
        {
            a.Start();
            b.Start();
            c.Start();
        }

        public static void Resheto()
        {
            int n = 1000;
            
            var numbers = new List<uint>();
            for (var i = 2u; i < n; i++)
            {
                numbers.Add(i);
            }

            for (var i = 0; i < numbers.Count; i++)
            {
                for (var j = 2u; j < n; j++)
                {
                    //удаляем кратные числа из списка
                    numbers.Remove(numbers[i] * j);
                }
            }
            var primeNumbers = numbers;

            Console.WriteLine("Простые числа до заданного {0}:", n);
            Console.WriteLine(string.Join(", ", primeNumbers));
        }
        public static void CancelIfTooLongResheto()
        {
            

            var numbers = new List<uint>();
            for (var i = 2u; i < n; i++)
            {
                numbers.Add(i);
            }

            for (var i = 0; i < numbers.Count; i++)
            {
                for (var j = 2u; j < n; j++)
                {
                    //удаляем кратные числа из списка
                    numbers.Remove(numbers[i] * j);

                }

            }
            var primeNumbers = numbers;

            Console.WriteLine("Простые числа до заданного {0}:", n);
            Console.WriteLine(string.Join(", ", primeNumbers));
        }

    }
}
