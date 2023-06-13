using System.Collections;
namespace NonGenericArray;
class Program
{
    static void Main(string[] args)
    {
        var employeeInfo = new List<Tuple<int, string, string, DateTime>>();
        employeeInfo.Add(new Tuple<int, string, string,
            DateTime>(3, "Zack", "Peterson", new DateTime(2022, 12, 3)));

        employeeInfo.Add(Tuple.Create(1, "Adam", "Green", new DateTime(2013, 02, 05)));
        employeeInfo.Add(Tuple.Create(2, "Mikheil", "Ivanishvili", new DateTime(2013, 07, 12)));
        Console.WriteLine("Standart");
        foreach(var ite in employeeInfo)
        {
            Console.WriteLine($"Employee Number - {ite.Item1}\n" +
                $"Name - {ite.Item2}\n" +
                $"Surname - {ite.Item3}\n" +
                $"Date - {ite.Item4.ToShortDateString()}");
            Console.WriteLine();
        }
        employeeInfo.Sort();
        Console.WriteLine("Sorted");
        foreach (var ite in employeeInfo)
        {
            Console.WriteLine($"Employee Number - {ite.Item1}\n" +
                $"Name - {ite.Item2}\n" +
                $"Surname - {ite.Item3}\n" +
                $"Date - {ite.Item4.ToShortDateString()}");
            Console.WriteLine();
        }
        employeeInfo.Reverse();
        Console.WriteLine("Reversed");
        foreach (var ite in employeeInfo)
        {
            Console.WriteLine($"Employee Number - {ite.Item1}\n" +
                $"Name - {ite.Item2}\n" +
                $"Surname - {ite.Item3}\n" +
                $"Date - {ite.Item4.ToShortDateString()}");
            Console.WriteLine();
        }

    }
}
