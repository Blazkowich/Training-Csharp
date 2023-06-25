using System.Diagnostics;
namespace delegates
{
    public delegate void DisplayPlayer(Dictionary<int,string> players);
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> listOfPlayers = new Dictionary<int,string>();
            listOfPlayers.Add(7, "Ronaldo");
            listOfPlayers.Add(10, "Messi");
            listOfPlayers.Add(8, "Iniesta");

            DisplayPlayer player = new DisplayPlayer(DisplayPlayerInfo);

            player(listOfPlayers);
        }

        public static void DisplayPlayerInfo(Dictionary<int,string> players)
        {
            foreach(var player in players)
            {
                Console.WriteLine($"Player No : {player.Key}\nPlayer Name : {player.Value}");
            }
        }
    }
}
