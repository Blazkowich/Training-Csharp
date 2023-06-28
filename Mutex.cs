using System.Threading;
namespace Threads;

using System.Threading;
class Program
{
    private static Mutex mut = new Mutex();
    static void Main(string[] args)
    {
        for (int i = 0; i < 3; i++)
        {
            Thread newThread = new Thread(new ThreadStart(delegate ()
            {
                for (int d = 0; d < 1; d++)
                {
                    UseResource();
                }
            }));
            newThread.Name = string.Format("(Thread no. {0}", i + 1);
            newThread.Start();
        }
    }

     private static void UseResource()
    {
        Console.WriteLine("{0} is requesting the mutex", Thread.CurrentThread.Name);
        mut.WaitOne();

        Console.WriteLine("{0} has entered the critical section", Thread.CurrentThread.Name);
        Thread.Sleep(2000);
        Console.WriteLine("{0} is leaving the critical section", Thread.CurrentThread.Name);

        mut.ReleaseMutex();
        Console.WriteLine("{0} has released the mutex", Thread.CurrentThread.Name);

    }
}


