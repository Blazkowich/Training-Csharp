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
        }

        public static bool isAdmin()
        {
            return false;
        }
    }
}
