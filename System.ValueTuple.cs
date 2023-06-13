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
        Console.WriteLine();

        var ronaldoGoals = (Year2017: 64, Year2016: 60, Year2015: 50);

        var ronaldhinio = (playerNo: 7, playerName: "Ronaldo", playerGoals: ronaldoGoals);

        Console.WriteLine(ronaldhinio.playerNo);
        Console.WriteLine(ronaldhinio.playerName);
        Console.WriteLine("2015 " + ronaldhinio.playerGoals.Year2015);
        Console.WriteLine("2016 " + ronaldhinio.playerGoals.Year2016);
        Console.WriteLine("2017 " + ronaldhinio.playerGoals.Year2017);
        Console.WriteLine();
    }
}
