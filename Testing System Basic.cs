namespace TestSystem
{
    class Program
    {
        static Dictionary<string, int> nameUser = new Dictionary<string, int>()
        {
            { "Goga", 0 },
            { "Vaja", 0 },
            { "Koba", 0 },
            { "Bejani", 0 }
        };

        static string currentUser = "";

        static void Main(string[] args)
        {
            Login();
        }

        public static void Login()
        {
            bool loggedIn = false;
            do
            {
                Console.WriteLine("Please Enter Your Name: ");
                string name = Console.ReadLine();

                if (nameUser.ContainsKey(name))
                {
                    currentUser = name;
                    loggedIn = true;
                    Console.WriteLine($"Hello {currentUser}, Please Get Ready for the Exam!");
                    Tests();
                }
                else if(name.ToLower() == "exit")
                {
                    Console.WriteLine("Bye!");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("You're Not a User. Please Register!");
                }
            } while (!loggedIn);

            Console.WriteLine($"Logged Out from User: {currentUser}");

            Login();
        }

        public static void Tests()
        {
            Dictionary<string, int> testsWithAnswers = new Dictionary<string, int>()
            {
                { "How Old Are You?", 2 },
                { "How Are You?", 1 }
            };

            foreach (KeyValuePair<string, int> test in testsWithAnswers)
            {
                Console.WriteLine();
                Console.WriteLine(test.Key);
                Console.WriteLine("Choose: ");

                if (test.Key == "How Old Are You?")
                {
                    Console.WriteLine("1. 3 Years Old");
                    Console.WriteLine("2. 21 Years Old");
                    Console.WriteLine("3. Ra Sheni Trakis Saqmea!");
                }
                else if (test.Key == "How Are You?")
                {
                    Console.WriteLine("1. Good");
                    Console.WriteLine("2. Bad");
                    Console.WriteLine("3. Neutral");
                }

                int answ = int.Parse(Console.ReadLine());

                if (answ > 0 && answ < 4 && answ == test.Value)
                {
                    nameUser[currentUser]++;
                    Console.WriteLine("Yes!");
                }
                else
                {
                    nameUser[currentUser]--;
                    Console.WriteLine("Wrong!");
                }
            }
            Console.WriteLine($"{currentUser} Has Completed the Test.\n" +
                $"Points: {nameUser[currentUser]}");
            CheckPoints();
        }

        public static void CheckPoints()
        {
            Console.WriteLine("\nCurrent Points:");
            Console.WriteLine();
            foreach (KeyValuePair<string, int> user in nameUser)
            {
                Console.WriteLine($"User: {user.Key}\nPoints: {user.Value}");
                Console.WriteLine();
            }
        }
    }
}
