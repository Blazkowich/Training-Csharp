namespace recursiveMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayPlayerInformation(7, "Ronaldo", 60, "Portugal", "Real Madrid");
            Console.WriteLine("--------------");
            DisplayPlayerInformation(10,"Messi", 55);
        }

        public static void DisplayPlayerInformation(int no, string name, int goals, string country = "", string club = "")
        {
            Console.WriteLine(no);
            Console.WriteLine(name);
            Console.WriteLine(goals);
            Console.WriteLine(country);
            Console.WriteLine(club);
        }
    }
}
