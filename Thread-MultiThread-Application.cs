using System.Threading;
namespace Threads;

class Program
{
    static void Main(string[] args)
    {
        Thread t1 = new Thread(new ThreadStart(delegate
        {
            Console.WriteLine("Process 1 Started");
            Console.WriteLine("Process 1 Is Running");
            for (long i = 0; i < 2_500_000_000; i++)
            { }
            Console.WriteLine("Process 1 has been completed \n");
        }));
        t1.Start();

        Thread t2 = new Thread(new ThreadStart(delegate
        {
            Console.WriteLine("Process 2 Started");
            Console.WriteLine("Process 2 Is Running");
            for (long i = 0; i < 5_000_000_000; i++)
            { }
            Console.WriteLine("Process 2 has been completed \n");
        }));
        t2.Start();

        Thread t3 = new Thread(new ThreadStart(delegate
        {
            Thread.Sleep(1);
            Console.WriteLine("what is your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + " Welcome Back");
        }));
        t3.Start();
    }
}

