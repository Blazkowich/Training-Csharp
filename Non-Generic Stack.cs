using System.Collections;
namespace NonGenericArray;
class Program
{
    static void Main(string[] args)
    {
        // Creating

        Stack stack = new Stack();

        // Adding
        stack.Push("David");
        stack.Push("Emmy");
        stack.Push("Jack");
        stack.Push("Heimlih");

        // Removing

        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
    }
}
