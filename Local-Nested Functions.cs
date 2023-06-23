namespace recursiveMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PerformMathOperations(1,2,3,4,5);
        }

        public static void PerformMathOperations(params int[] numbers)
        {
            Console.WriteLine("Add = " + AddNumbers());
            int AddNumbers()
            {
                int result = 0;

                foreach(var number in numbers)
                {
                    result += number;
                }
                return result;
            }

            Console.WriteLine("Multiple = " + MultipleNumbers());
            int MultipleNumbers()
            {
                int result = 1;

                foreach (var number in numbers)
                {
                    result *= number;
                }
                return result;
            }
        }
    }
}
