using Lab15;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Runtime.InteropServices;


Console.Write("N = ");
int n = (int)Convert.ToUInt32(Console.ReadLine());


CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
CancellationToken token = cancelTokenSource.Token;

Task task = new Task(
    () =>
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
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Операция прервана");
                return;
            }

        }
        var primeNumbers = numbers;

        Console.WriteLine("Простые числа до заданного {0}:", n);
        Console.WriteLine(string.Join(", ", primeNumbers));
    }




    , token);
Stopwatch stopWatch = new Stopwatch();
stopWatch.Start();
task.Start();




Console.WriteLine(task.CreationOptions);
Console.WriteLine(task.Status);
Console.WriteLine(task.IsFaulted);
Console.WriteLine(task.Id);

for (; task.IsCompleted == false;)
{
    Thread.Sleep(1000);

    if (stopWatch.Elapsed.TotalSeconds >= 5)
    {

        cancelTokenSource.Cancel();

    }
}
task.Wait();
stopWatch.Stop();

TimeSpan ts = stopWatch.Elapsed;

string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
Console.WriteLine("RunTime " + elapsedTime);


Console.ReadLine();

Task task1 = new Task(() => SomeTasks.SquareAsync(100));
Task task2 = new Task(() => SomeTasks.DelenieAsync(10000));
Task task3 = new Task(() => SomeTasks.UmnozhAsync(10));


Task task4 = new Task(() => SomeTasks.AllAsync(task1, task2, task3));
Task task5 = task4.ContinueWith(SomeTasks.Continue);

task4.Start();

task4.WaitAsync(new TimeSpan(0, 0, 5));

task5.Wait();

Task<int> task6 = new Task<int>(()
   => {
       Random a = new Random();
       int b = a.Next();
       return b;
   });
task6.Start();
int result = task6.GetAwaiter().GetResult();
Console.WriteLine(result);




//Parallel.For(0, 10000, SomeTasks.PlusArray);



//ParallelLoopResult result1 = Parallel.ForEach<int>(
//       new List<int>() { 1, 3, 5, 8 },
//       SomeTasks.PlusArray
//);



Parallel.Invoke(SomeTasks.Resheto, SomeTasks.Resheto);




Console.WriteLine("Склад");
Console.ReadLine();

// The token source for issuing the cancelation request.
var cts = new CancellationTokenSource();

// A blocking collection that can hold no more than 100 items at a time.
var numberCollection = new BlockingCollection<Tech>(100);

if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
{
    int width = Math.Max(Console.BufferWidth, 80);
    int height = Math.Max(Console.BufferHeight, 8000);

    // Preserve all the display output for Adds and Takes
    Console.SetBufferSize(width, height);
}

// The simplest UI thread ever invented.
Task.Run(() =>
{
    if (Console.ReadKey(true).KeyChar == 'c')
    {
        cts.Cancel();
    }
});

// Start one producer and one consumer.
Task t1 = Task.Run(() => Sklad.NonBlockingConsumer(numberCollection, cts.Token));
Task t2 = Task.Run(() => Sklad.NonBlockingConsumer(numberCollection, cts.Token));
Task t3 = Task.Run(() => Sklad.NonBlockingConsumer(numberCollection, cts.Token));
Task t4 = Task.Run(() => Sklad.NonBlockingConsumer(numberCollection, cts.Token));
Task t5 = Task.Run(() => Sklad.NonBlockingConsumer(numberCollection, cts.Token));
Task t6 = Task.Run(() => Sklad.NonBlockingConsumer(numberCollection, cts.Token));
Task t7 = Task.Run(() => Sklad.NonBlockingConsumer(numberCollection, cts.Token));
Task t8 = Task.Run(() => Sklad.NonBlockingConsumer(numberCollection, cts.Token));
Task t9 = Task.Run(() => Sklad.NonBlockingConsumer(numberCollection, cts.Token));
Task t10 = Task.Run(() => Sklad.NonBlockingConsumer(numberCollection, cts.Token));
Task t11 = Task.Run(() => Sklad.NonBlockingProducer(numberCollection, cts.Token, "TV", 100));
Task t12 = Task.Run(() => Sklad.NonBlockingProducer(numberCollection, cts.Token, "Fridge", 2000));
Task t13 = Task.Run(() => Sklad.NonBlockingProducer(numberCollection, cts.Token, "CoffeMachine", 3000));
Task t14 = Task.Run(() => Sklad.NonBlockingProducer(numberCollection, cts.Token, "Multivarka", 4000));
Task t15 = Task.Run(() => Sklad.NonBlockingProducer(numberCollection, cts.Token, "Pilesos", 5000));

// Wait for the tasks to complete execution
Task.WaitAll(t1, t2);

cts.Dispose();
Console.WriteLine("Press the Enter key to exit.");
Console.ReadLine();



