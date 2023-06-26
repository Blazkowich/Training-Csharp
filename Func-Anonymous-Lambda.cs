namespace LambdaExpresion;


class Program
{
    static void Main(string[] args)
    {
        string name = "Ahmad";

        // Func
        Func<string, string> ConvertToUppercase = UpperCaseString;
        Console.WriteLine("Using Func");
        Console.WriteLine(ConvertToUppercase(name));

        // Anonymous Method
        Func<string, string> anonymousMethod = delegate (string myName) { return myName.ToUpper(); };
        Console.WriteLine("Using Anonymous");
        Console.WriteLine(anonymousMethod(name));

        // Lambda Expression
        Func<string, string> lambdaExpression = text => text.ToUpper();
        Console.WriteLine("Using Lambda");
        Console.WriteLine(lambdaExpression(name));
    }

    public static string UpperCaseString(string inputString)
    {
        return inputString.ToUpper();
    }
}

