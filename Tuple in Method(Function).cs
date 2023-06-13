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

        var james = Tuple.Create(105, "James", "Watson", "Kazbegi ave 15", "Tbilisi",
            "Developer", "Georgian");
        Display(james);

        var sansa = Tuple.Create(106, "Sansa", "Kolakua",
            "Vazha Shavela 1", "Tbilisi", "Tutuci", "Zangi");
        Display(sansa);
    }

    public static void Display(Tuple<
            int, string, string, string,
            string, string, string
            > employeeInfo)
    {
        Console.WriteLine("Name - " + employeeInfo.Item2);
        Console.WriteLine("Last Name - " + employeeInfo.Item3);
        Console.WriteLine("Adress - " + employeeInfo.Item4);
        Console.WriteLine("City - " + employeeInfo.Item5);
        Console.WriteLine("Job Title - " + employeeInfo.Item6);
        Console.WriteLine("Nationality - " + employeeInfo.Item7);
        Console.WriteLine();
    }
}
