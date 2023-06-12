using System.Collections;
namespace NonGenericArray;
class Program
{
    static void Main(string[] args)
    {
        ArrayList array = new ArrayList();
        #region Adding
        // Adding
        array.Add("First");
        array.Add("Third");
        array.Add("Fourth");
        array.Add("Fifth");

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
        #endregion
        #region Insert
        // Insert
        Console.WriteLine("-----------------");
        Console.WriteLine("After Insertion");
        array.Insert(2, "Second");
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
        #endregion

        #region Indexing
        // Index

        Console.WriteLine("-----------------");
        int ind = 2;
        Console.WriteLine($"On Index {ind} Is - " +
        array[ind].ToString());
        #endregion

        #region Capacity
        // Capacity

        Console.WriteLine("-----------------");
        Console.WriteLine("Capacity - " + array.Count);
        #endregion

        #region Sorting
        // Sorting

        Console.WriteLine("------------------");
        array.Sort();
        foreach (var item in array)
        {
            Console.WriteLine("Sorted Array - " + item);
        }
        #endregion


        #region Reverse
        // Reverse

        Console.WriteLine("------------------");
        array.Reverse();
        foreach (var item in array)
        {
            Console.WriteLine("Reversed Array - " + item);
        }
        #endregion

        #region Contains
        Console.WriteLine("----------------------");
        Console.WriteLine($"If Array Contains {"Third"} - {array.Contains("Third")}");
        #endregion

        #region GetRange
        Console.WriteLine("-----------------------");
        Console.WriteLine("Get Range - ");
        ArrayList numbers = new ArrayList();
        numbers = array.GetRange(0, 2);
        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }
        #endregion

        #region Remove
        // Remove
        Console.WriteLine("------------------");
        // Remove By Name
        array.Remove("Second");

        //Remove by index
        //array.RemoveAt(2);
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
        #endregion

        #region Remove Range
        // Remove Range

        Console.WriteLine("------------------");

        array.RemoveRange(1,3);
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
        #endregion

        #region Remove All
        // Remove All

        Console.WriteLine("------------------");

        array.Clear();
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
        #endregion
    }
}
