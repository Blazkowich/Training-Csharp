using System.Collections;
namespace NonGenericArray;
class Program
{
    static void Main(string[] args)
    {
        // Creating

        Queue queue = new Queue();

        // Adding

        queue.Enqueue("Koba");
        queue.Enqueue("Ahmad");
        queue.Enqueue("Vaja");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }

        // Removing
        Console.WriteLine();
        Console.WriteLine(queue.Dequeue());
    }
}
