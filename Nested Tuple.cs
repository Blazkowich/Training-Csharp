using System.Collections;
namespace NonGenericArray;
class Program
{
    static void Main(string[] args)
    {
        var employeeInfo = new Tuple<
            int, string, string, string,
            string, string, string,
            Tuple < decimal, decimal, decimal, decimal, decimal >>
            (105,"James","Watson","Kazbegi ave 15","Tbilisi",
            "Developer","Georgian",Tuple.Create(2000m,3000m,4000m,5000m,6000m));

        Console.WriteLine("Name - " + employeeInfo.Item2);
        Console.WriteLine("Last Name - " + employeeInfo.Item3);
        Console.WriteLine("Adress - " + employeeInfo.Item4);
        Console.WriteLine("City - " + employeeInfo.Item5);
        Console.WriteLine("Job Title - " + employeeInfo.Item6);
        Console.WriteLine("Nationality - " + employeeInfo.Item7);
        Console.WriteLine();
        Console.WriteLine("Last 5 Salaries:");
        Console.WriteLine(employeeInfo.Rest.Item1);
        Console.WriteLine(employeeInfo.Rest.Item2);
        Console.WriteLine(employeeInfo.Rest.Item3);
        Console.WriteLine(employeeInfo.Rest.Item4);
        Console.WriteLine(employeeInfo.Rest.Item5);

    }
}
