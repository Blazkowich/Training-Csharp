using System.Diagnostics;
namespace delegates
{
    public delegate void DoSomethingDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watchOne = new Stopwatch();
            Stopwatch watchTwo = new Stopwatch();
            DoSomethingDelegate taskOne = new DoSomethingDelegate(DoSomething);


            // Using Delegates
            Console.WriteLine("Delegate Method \n----------");
            watchOne.Start();
            taskOne();
            watchOne.Stop();
            var elapsedTime = watchOne.Elapsed;
            Console.WriteLine(Math.Round(elapsedTime.TotalSeconds, 2));

            // Using Direct Call
            Console.WriteLine("Direct Method \n----------");
            watchTwo.Start();
            DoSomething();
            watchTwo.Stop();
            var elapsedTimeTwo = watchTwo.Elapsed;
            Console.WriteLine(Math.Round(elapsedTimeTwo.TotalSeconds, 2));

            Console.WriteLine("\nDelegates Saved " + Math.Round((elapsedTimeTwo.TotalMilliseconds - elapsedTime.TotalMilliseconds),4) + "Milliseconds");
            Console.WriteLine("\nDelegates Saved " + Math.Round((elapsedTimeTwo.TotalSeconds - elapsedTime.TotalSeconds),4) + "Seconds");
            
        }

        public static void DoSomething()
        {
            double number = 8.543231;
            List<double> list = new List<double>();
            for (double i = 0; i < 600_000_000; i++)
            {
                number += i + DateTime.Now.Second;
                list.Add(number);
            }
            list.Reverse();
        }
    }
}
