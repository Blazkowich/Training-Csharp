using System.Collections;
namespace NonGenericArray;
class Program
{
    static void Main(string[] args)
    {
        SortedList sorted = new SortedList();

        // Adding
        sorted.Add(1,"Jan");
        sorted.Add(2, "Feb");
        sorted.Add(3, "Mar");
        sorted.Add(4, "Apr");
        sorted.Add(5, "May");
        sorted.Add(6, "Jun");
        sorted.Add(7, "Jul");
        sorted.Add(8, "Aug");
        sorted.Add(9, "Sep");
        sorted.Add(10, "Oct");
        sorted.Add(11, "Nov");
        sorted.Add(12, "Dec");


        // Displaying
        // Foreach
        Console.WriteLine();
        Console.WriteLine("Foreach Loop");
        foreach (DictionaryEntry item in sorted)
        {
            Console.WriteLine(item.Key + " " + item.Value);
        }
        //For
        Console.WriteLine();
        Console.WriteLine("For Loop");
        for (int i = 0; i < sorted.Count; i++)
        {
            Console.WriteLine(sorted.GetKey(i) + ": " + sorted.GetByIndex(i));
        }

        // Index
        Console.WriteLine();
        Console.WriteLine("Indexing");
        Console.WriteLine(sorted[2].ToString());

        // Capacity
        Console.WriteLine();
        Console.WriteLine("Capacity - " + sorted.Capacity);

        //Remove
        Console.WriteLine();
        //sorted.Remove(2); // By Numer
        //sorted.RemoveAt(2); // By Index
        foreach (DictionaryEntry item in sorted)
        {
            Console.WriteLine(item.Key + " " + item.Value);
        }

        // Contains
        Console.WriteLine();
        Console.WriteLine("Contains Jun");
        Console.WriteLine(sorted.ContainsValue("Jun"));


        // Copy to ArrayList
        Console.WriteLine();
        Console.WriteLine("Copy to ArrayList");
        ArrayList array = new ArrayList(sorted.Values);

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}
