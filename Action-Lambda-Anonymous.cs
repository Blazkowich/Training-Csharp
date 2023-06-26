namespace LambdaExpresion;


class Program
{
    static void Main(string[] args)
    {
        string name = "Ahmad";

        // Func
        Action<string> ConvertToUppercase = UpperCaseString;
        Console.WriteLine("Using Action");
        ConvertToUppercase(name);

        // Anonymous Method
        Action<string> anonymousMethod = delegate (string myName) { Console.WriteLine(name.ToUpper()); };
        Console.WriteLine("Using Lambda");
        anonymousMethod(name);

        // Lambda Expression
        Action<string> lambdaExpression = text => Console.WriteLine(name.ToUpper());
        Console.WriteLine("Using Lambda");
        lambdaExpression(name);
    }

    public static void UpperCaseString(string inputString)
    {
        Console.WriteLine(inputString.ToUpper());
    }
}

