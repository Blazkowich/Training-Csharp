namespace LambdaExpresion;


class Program
{
    static void Main(string[] args)
    {
        Func<int, int, int> funcDne = AddTwoNumbers;

        Console.WriteLine(AddTwoNumbers(3, 5));

        Func<int> funcTwo = AddTwoNumbers;

        Console.WriteLine(funcTwo());
    }

    public static int AddTwoNumbers(int x, int y)
    {
        return x + y;
    }

    public static int AddTwoNumbers()
    {
        int z = 0;
        int x = 5;
        int y = 2;

        z = x + y;

        return z;
    }
}

