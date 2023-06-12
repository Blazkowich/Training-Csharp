using System.Collections;
namespace NonGenericArray;
class Program
{
    static void Main(string[] args)
    {
        //Creating

        Hashtable hash = new Hashtable();

        // Adding

        hash.Add("Microsoft", "USA");
        hash.Add("Sony", "Japan");
        hash.Add("IKEA", "Sweden");
        hash.Add("Mercedes", "Germany");

        // Displaying
        Console.WriteLine("----------------------");
        foreach (DictionaryEntry item in hash)
        {
            Console.WriteLine(item.Key + " " + item.Value);
        }

        // Capacity

        Console.WriteLine("----------------------");
        Console.WriteLine("Count is: " + hash.Count);

        // Remove

        Console.WriteLine("----------------------");
        hash.Remove("IKEA");
        foreach (DictionaryEntry item in hash)
        {
            Console.WriteLine(item.Key + " " + item.Value);
        }

        // Contains

        Console.WriteLine("----------------------");
        string name = "Sony";
        if(hash.Contains(name)) // or ContainsValue
        {
            Console.WriteLine($"Yes, the collection contains {name}");
        }
        else
        {
            Console.WriteLine($"No, it doesn't Contains {name}");
        }


        // Copy to ArrayList
        Console.WriteLine("---------------------");
        ArrayList array = new ArrayList(hash.Keys); // Keys or Values
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}
