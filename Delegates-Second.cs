namespace delegates
{
    // void delegate with one string and one int
    public delegate void PlayerInformationWithGoals(string playerName, int playerGoals);

    // string delegate with one int and one string
    public delegate string PlayerInformationBasedOnNumberAndClub(int playerNo, string club, string country = "Unknown");

    class Program
    {        
        static void Main(string[] args)
        {
            PlayerInformationWithGoals playerOne = new PlayerInformationWithGoals(DisplayInformation);
            PlayerInformationBasedOnNumberAndClub playerTwo = new PlayerInformationBasedOnNumberAndClub(DisplayInformation);

            //playerOne("Ronney", 50);

            //playerTwo(7, "MU", "England");

            foreach ( var item in playerTwo.Method.GetParameters())
            {
                Console.WriteLine($"{item.ParameterType.Name}, {item.Name}, {item.Position}, {item.IsOptional}, {item.DefaultValue}");
            }
        }

        public static void DisplayInformation(string playerName, int playerGoals)
        {
            Console.WriteLine("Player: " + playerName + " Score: " + playerGoals);
        }

        public static string DisplayInformation(int number, string club, string country = "Unknown")
        {
            //Some Logic Here
            Console.WriteLine("Hi...");
            return string.Empty;
        }
    }
}
