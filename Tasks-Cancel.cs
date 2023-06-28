using System;
using System.Threading.Tasks;
using System.Timers;
class Program
{

    static void Main(string[] args)
    {
        CancellationTokenSource cancellation = new CancellationTokenSource();
        CancellationToken token = cancellation.Token;

        Task task = new Task(() =>
        {
            for (int i = 0; i < 100000; i++)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Task is cancelled!");
                    return;
                }
                else
                {
                    Console.WriteLine(i + 1);
                }
            }
            Console.WriteLine("Task is Complete!");
        });

        task.Start();

        Thread.Sleep(3000);
        cancellation.Cancel();


        Console.ReadLine();
    }
}
