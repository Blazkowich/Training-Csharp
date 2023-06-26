namespace LambdaExpresion;


class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();

        list.Add(5); list.Add(8); list.Add(6); list.Add(15);
        list.Add(7); list.Add(2); list.Add(1); list.Add(12);

        var oddList = list.Where(n => n % 2 != 0).ToList();

        var evenList = list.Where(n => n % 2 == 0).ToList();

        Console.WriteLine("ODD");
        foreach (var item in oddList)
        {
            
            Console.WriteLine(item);

        }

        Console.WriteLine("------------");

        Console.WriteLine("EVEN");
        foreach (var item in evenList)
        {
            Console.WriteLine(item);
        }
    }
}

