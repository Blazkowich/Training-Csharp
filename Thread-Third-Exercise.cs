using System.Threading;
namespace Threads;

class Program
{
    static void Main(string[] args)
    {
        //Exercise 1
        Thread t1 = new Thread(new ThreadStart(() => Console.WriteLine("Lambda")));
        t1.Start();

        //Exercise 2
        Thread t2 = new Thread(new ThreadStart(delegate ()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Anonymous");
            }
        }));
        t2.Start();
    }
}

