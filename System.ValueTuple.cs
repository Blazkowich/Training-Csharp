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
    }
}
