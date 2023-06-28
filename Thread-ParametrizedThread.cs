using System.Threading;
namespace Threads;

using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        Helper helper = new Helper();
        Thread t1 = new Thread(new ParameterizedThreadStart(helper.Loop));
        t1.Start();
    }
}

class Helper
{
    public void Loop(object number)
    {
        for (int i = 0; i < int.Parse(number.ToString()); i++)
        {
            Console.WriteLine(i);
        }
    }
}

