using System.Collections;
namespace NonGenericArray;
class Program
{
    static void Main(string[] args)
    {
        (int playerNo, string playerName, int playerGoals) ronaldo = (7, "Ronaldo", 55);

        Console.WriteLine(ronaldo.playerNo);
        Console.WriteLine(ronaldo.playerName);
        Console.WriteLine(ronaldo.playerGoals);
        Console.WriteLine();

        var messi = (playerNo: 10, playerName: "Messi", playerGoals: 100);

        Console.WriteLine(messi.playerNo);
        Console.WriteLine(messi.playerName);
        Console.WriteLine(messi.playerGoals);
    }
}
