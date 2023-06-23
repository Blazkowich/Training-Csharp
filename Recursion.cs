namespace recursiveMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 5;

            Console.WriteLine("Non-Recursive Way");
            Console.WriteLine(FactorialNonRecursive(number));

            Console.WriteLine("Recursive Way");
            Console.WriteLine(FactorialRecursive(number));
        }

        public static int FactorialNonRecursive(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            int value = 1;
            for(int i = num; i > 0; i--)
            {
                value *= i;
                Console.WriteLine(i);
            }
            return value;
        }

        public static int FactorialRecursive(int num)
        {
            if(num == 0)
            {
                return 1;
            }
            return num * FactorialRecursive(num - 1);
        }
    }
}
