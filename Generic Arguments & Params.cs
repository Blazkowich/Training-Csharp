namespace recursiveMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoopThroughArray(10, 50, 25, 3);

            LoopThroughArray("Iasoni", "Bejani", "Guja", "Koba");
        }

        public static void LoopThroughArray<T>(params T[] names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("-------------------");
        }
    }
}
