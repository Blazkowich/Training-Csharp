using System.Diagnostics;

namespace stopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Loop(100_000_000);
            sw.Stop();

            Console.WriteLine("Seconds " + sw.Elapsed.TotalSeconds);
            Console.WriteLine("Milliseconds " + sw.Elapsed.Milliseconds);
            Console.WriteLine("Total Milliseconds " + sw.Elapsed.TotalMilliseconds);
        }

        public static void Loop(long number)
        {
            for (long i = 0; i < number; i++)
            {

            }
            Console.WriteLine("Process Done.");
        }
    }
}
