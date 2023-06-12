using System.Collections;
namespace NonGenericArray;
class Program
{
    static void Main(string[] args)
    {
        // Creating

        Dictionary<string, string> capital = new Dictionary<string, string>();


        // Creating with initialization


        // Add
        capital.Add("Georgia", "Tbilisi");
        capital.Add("Italy", "Rome");
        capital.Add("Armenia", "Erevan");
        capital.Add("Germany", "Berlin");

        // Displaying Foreach
        foreach (var item in capital)
        {
            Console.WriteLine(item.Value + " - " + item.Key);
        }
        Console.WriteLine();
        // Displaying For
        for (int i = 0; i < capital.Count; i++)
        {
            Console.WriteLine(capital[capital.Keys.ElementAt(i)]);
        }
        Console.WriteLine();
        // Index
        Console.WriteLine(capital["Italy"]);

        // Capacity
        Console.WriteLine(capital.Count);
        Console.WriteLine();

        // Try get Values
        capital.TryGetValue("Germany", out string result);
        if (result != null)
        {
            Console.WriteLine("Result is " + result);
        }
        // Contains
        Console.WriteLine();
        Console.WriteLine(capital.ContainsKey("Armenia"));

    }
}
