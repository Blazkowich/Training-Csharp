using System;
using System.Threading.Tasks;
using System.Timers;
class Program
{

    static void Main(string[] args)
    {
        Task t1 = new Task(() =>
        {
            Console.WriteLine("Task 1 started");
            Console.WriteLine("Task 1 Running...\n");
            Thread.Sleep(8000);
            Console.WriteLine("Task 1 finished");
        });
        t1.Start();
        //t1.Wait(1000);

        Task t2 = new Task(() =>
        {
            Console.WriteLine("Task 2 started");
            Console.WriteLine("Task 2 Running...\n");
            Thread.Sleep(6000);
            Console.WriteLine("Task 2 finished");
        });
        t2.Start();

        Task t3 = new Task(() =>
        {
            Console.WriteLine("Task 3 started");
            Console.WriteLine("Task 3 Running...\n");
            Thread.Sleep(2000);
            Console.WriteLine("Task 3 finished");
        });
        t3.Start();

        Task.WaitAll(t1,t2,t3);
    }
}
