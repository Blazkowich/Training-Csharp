namespace LambdaExpresion;


class Program
{
    static void Main(string[] args)
    {
        Predicate<int> condition = isAdmin;
        Console.WriteLine(condition(11));
    }

    public static bool isAdmin(int empNo)
    {
        if (empNo == 10)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

