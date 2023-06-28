using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        Task<int> task = new Task<int>(() =>
            {
                int result = 0;
                for (int i = 1; i < 5; i++)
                {
                    result += i;
                    Console.WriteLine(i);
                }
                return result;
            });
        task.Start();
        Console.WriteLine(task.Result);
        Console.ReadLine();
    }
}


