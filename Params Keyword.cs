namespace recursiveMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoopThroughArray("Jack", "Vaja", "Babo", "Gela");
            Console.WriteLine("-------------------");
            LoopThroughArray("Iasoni", "Bejani", "Guja", "Koba");
        }

        public static void LoopThroughArray(params string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
