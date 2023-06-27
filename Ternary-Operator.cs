namespace ternaryoperator
{
    class Program
    {
        static void Main(string[] args)
        {

            // Standart
            if(isAdmin())
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            //Ternary Operator
            Console.WriteLine(isAdmin() ? "Yes":"No");

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(number % 2 == 0 ? "Even":"Odd");
        }

        public static bool isAdmin()
        {
            return false;
        }
    }
}
