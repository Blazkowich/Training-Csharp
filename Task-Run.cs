using System;
using System.Threading.Tasks;
using System.Timers;
class Program
{

    static void Main(string[] args)
    {
        SayHi();

        AddNumbersTask(1, 2, 3, 4);

        Console.ReadLine();
    }

    private static void SayHi()
    {
        Task.Run(() =>
        {
            Console.WriteLine("Hi There");
        });
    }

    public static Task AddNumbersTask(params int[] numbers)
    {
        return Task.Run(() =>
        {
            Console.WriteLine("Add Numbers started...");
            int result = 0;
            foreach (var number in numbers)
            {
                result += number;
            }
            Console.WriteLine("Total = " + result);
        });
    }
}
