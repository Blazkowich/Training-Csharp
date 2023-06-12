using System.Collections;
namespace NonGenericArray;
class Program
{
    static void Main(string[] args)
    {
        // Creating
        List<string> firstList = new List<string>();
        IList<string> secondList = new List<string>();

        // Adding
        firstList.Add("England");
        firstList.Add("Germany");
        firstList.Add("China");

        // Displaying
        foreach (var item in firstList)
        {
            Console.WriteLine(item);
        }

        // Index
        //Console.WriteLine();
        //Console.WriteLine(firstList[0]);

        // Capacity
        Console.WriteLine();
        Console.WriteLine(firstList.Count);

        // Sorting
        Console.WriteLine();
        firstList.Sort();
        foreach (var item in firstList)
        {
            Console.WriteLine(item);
        }


        // Reversing
        Console.WriteLine();
        firstList.Reverse();

        foreach (var item in firstList)
        {
            Console.WriteLine(item);
        }

        // Removing
        //Console.WriteLine();
        //firstList.Remove("China"); // Or RemoveAt Or RemoveAtRange
        //foreach (var item in firstList)
        //{
        //    Console.WriteLine(item);
        //}
        //Remove All
        //Console.WriteLine();
        //firstList.Clear();


        // Contains
        Console.WriteLine();
        Console.WriteLine(firstList.Contains("Egypt"));

        // Get Range
        Console.WriteLine();
        firstList.GetRange(0, 2);
        foreach (var item in firstList)
        {
            Console.WriteLine(item);
        }
    }
}
