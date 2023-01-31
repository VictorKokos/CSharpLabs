using System.Threading;
using System.Diagnostics;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab14;

DateTime current = DateTime.Now;
    foreach (Process process in Process.GetProcesses())
    {
    try
    {
        Console.WriteLine($"ID: {process.Id} " +
            $" Имя: {process.ProcessName}, Приоритет {process.BasePriority}, " +
            $"Время запуска: {process.StartTime}, Текущее состояние: {process.Responding}" +
            $"сколько всего времени использовал процессор: {current - process.StartTime}");
    }
    catch 
    {
        Console.WriteLine("ex");
    }
}

 
AppDomain domain = AppDomain.CurrentDomain;
Console.WriteLine($"Name: {domain.FriendlyName}");
Console.WriteLine($"Base Directory: {domain.BaseDirectory}");
Console.WriteLine();

Assembly[] assemblies = domain.GetAssemblies();
foreach (Assembly asm in assemblies)
    Console.WriteLine(asm.GetName().Name);


var asmb = Assembly.LoadFrom("HelloWorld.dll");

Console.WriteLine(asmb.GetName());


Lab14.Threads threads = new Lab14.Threads();
threads.n = Convert.ToInt32(Console.ReadLine());
ThreadStart threadDelegate = new ThreadStart(threads.CalculateSimple);
Thread myThread1 = new Thread(threadDelegate);
myThread1.Start();

Console.WriteLine($"{myThread1.IsAlive},{myThread1.Priority},{myThread1.ThreadState}   ");
myThread1.Interrupt();


ThreadStart threadDelegate2 = new ThreadStart(threads.Chet);
Thread myThread2 = new Thread(threadDelegate2);

ThreadStart threadDelegate3 = new ThreadStart(threads.NeChet);
Thread myThread3 = new Thread(threadDelegate3);
Thread.Sleep(1000);

myThread2.Priority = ThreadPriority.Highest;

Semaphore sem = new Semaphore(1, 1);

myThread3.Start();

myThread2.Start();



Console.ReadLine();
int num = 0;
// устанавливаем метод обратного вызова
TimerCallback tm = new TimerCallback(threads.Repeating);
// создаем таймер
Timer timer = new Timer(tm, num, 0, 2000);
Console.ReadLine();





