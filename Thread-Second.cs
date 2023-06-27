using System.Threading;
namespace Threads;

class Program
{
    static Thread t1;
    static Thread t2;

    static void Main(string[] args)
    {
        t1 = new Thread(new ThreadStart(SayHiEnglish));
        t1.Name = "Thread 1 (English)";
        t1.Start();

        t2 = new Thread(new ThreadStart(SayHiSpanish));
        t2.Name = "Thread 2 (Spanish)";
        t2.Start();
    }

    public static void SayHiEnglish()
    {
        Console.WriteLine("Starting " + Thread.CurrentThread.Name);
        for (int i = 0; i < 50; i++)
        {
            //Thread.Sleep(new TimeSpan(0, 0, 1));

            if (i == 32)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " Aborted");
                t1.Abort(); 
            }
            Console.WriteLine(i + " Hi...");
        }
    }

    public static void SayHiSpanish()
    {
        Console.WriteLine("Starting " + Thread.CurrentThread.Name);
        for (int i = 0; i < 50; i++)
        {
            //Thread.Sleep(new TimeSpan(0, 0, 1));
            Console.WriteLine(i + " Hola...");
        }
    }
}

