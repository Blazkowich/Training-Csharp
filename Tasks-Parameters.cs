using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        Task task1 = new Task(new Action<object>(sayHi), "Jennifer");
        task1.Start();

        Task task2 = new Task(delegate (object name)
        {
            Console.WriteLine("Welcome Back " + name);
        }, "ahmad");
        task2.Start();

        Task task3 = new Task(n => { Console.WriteLine("Welcome Back " + n); }, "Jack");
        task3.Start();

        Console.WriteLine();
    }

    public static void sayHi(object name)
    {
        Console.WriteLine("Welcome back " + name);
    }
}


