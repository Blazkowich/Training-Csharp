using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        Task task = new Task(new Action(sayHi));
        task.Start();

        Task task2 = new Task(delegate ()
        {
            Console.WriteLine("Task 2 is Starting");
            Console.WriteLine("Task 2 is running");
            Console.WriteLine("hi There");
            Thread.Sleep(7000);
            Console.WriteLine("Task 2 is complete");
        });
        task2.Start();

        Task task3 = new Task(() =>
        {
            Console.WriteLine("Task 3 is Starting");
            Console.WriteLine("Task 3 is running");
            Console.WriteLine("hi There");
            Thread.Sleep(9000);
            Console.WriteLine("Task 3 is complete");
        });

        task3.Start();

        Console.WriteLine("What is your name?");
        var name = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Welcome Back " + name);

        Console.ReadLine();

    }

    public static void sayHi()
    {
        Console.WriteLine("Task is Starting");
        Console.WriteLine("Task is running");
        Console.WriteLine("hi There");
        Thread.Sleep(5000);
        Console.WriteLine("Task is complete");
    }
}


