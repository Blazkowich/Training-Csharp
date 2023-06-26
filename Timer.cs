
using System.Timers;
namespace LambdaExpresion
{

    class Program
    {
        static void Main(string[] args)
        {

            Timer timer = new Timer();
            timer.Elapsed = OnEachSecond;
            timer.Interval = 3000;
            timer.Enabled = true;


            Console.WriteLine("Press (X) to exit");

            while (Console.Read() != 'X') ;
        }

        private static void OnEachSecond(object sender, ElapsedEventArgs a)
        {
            Console.WriteLine("Yes It Is Working " + DateTime.Now.ToLongTimeString());
        }
    }
}
