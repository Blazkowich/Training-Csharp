using System.Collections.Concurrent;
using System.Threading;

namespace AsynchAwaitApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentBag<int> bag = new();

            Thread t1 = new(() =>
            {
                Console.WriteLine("Thread (1) has Started");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Thread (1) added number " + i);
                    bag.Add(i);
                }
                Console.WriteLine("Thread (1) is comolete!");
            });

            Thread t2 = new(() =>
            {
                Console.WriteLine("Thread (2) has Started");
                for (int i = 11; i < 25; i++)
                {
                    Console.WriteLine("Thread (2) added number " + i);
                    bag.Add(i);
                }
                Console.WriteLine("Thread (2) is comolete!");
            });

            Thread t3 = new(() =>
            {
                Console.WriteLine("Thread (3) has started");
                foreach (var item in bag)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Thread (3) is comolete");
            });

            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
