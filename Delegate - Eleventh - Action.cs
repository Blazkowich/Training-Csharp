namespace LambdaExpresion;


class Program
{
    static void Main(string[] args)
    {
        Action<int> actionOne = DisplayInformation;
        actionOne(16);

        Action actionTwo = DisplayInformation;
        actionTwo();
    }

    public static void DisplayInformation(int number)
    {
        Console.WriteLine("Number " + number);
    }

    public static void DisplayInformation()
    {
        Console.WriteLine("Gabriel Batistuta"); 
    }
}

