namespace delegates
{
    class Program
    {
        //void Delegate with no argument
        public delegate void PlayerInfoDel();
        //void delegate with one string argument
        public delegate void PlayerInfoWithNameDel(string playerName);
        //void delegate with one string argument and one int
        public delegate void PlayerInfoWithNameAndNumDel(string name, int goals);
        //string delegate with one int argument
        public delegate string PlayerInfoWithName(int number);

        static void Main(string[] args)
        {
            //void Delegate with no argument
            PlayerInfoDel ronaldinho = new PlayerInfoDel(DisplayInformation);
            ronaldinho.Invoke();

            //void delegate with one string argument
            PlayerInfoWithNameDel playerName = new PlayerInfoWithNameDel(DisplayInformation);
            playerName("Messi");

            PlayerInfoWithNameAndNumDel newPlayer = new PlayerInfoWithNameAndNumDel(DisplayInformation);
            newPlayer("Ronaldo", 60);

            PlayerInfoWithName stringPlayer = new PlayerInfoWithName(DisplayInformation);
            Console.WriteLine(stringPlayer(7));
        }

        public static void DisplayInformation()
        {
            Console.WriteLine("Information about : Ronaldinho");
        }

        public static void DisplayInformation(string playerName)
        {
            Console.WriteLine("Information about : " + playerName);
        }

        public static void DisplayInformation(string playerName, int goals)
        {
            Console.WriteLine("Information about " + playerName + " and his score : " + goals);
        }

        public static string DisplayInformation(int number)
        {
            string playerName = string.Empty;
            switch(number)
            {
                case 7: playerName = "Ronaldo"; break;
                case 8: playerName = "Iniesta"; break;
                case 9: playerName = "Messi"; break;
                default: break;
            }
            return playerName;
        }
    }
}
