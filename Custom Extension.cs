namespace recursiveMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 50;

            Console.WriteLine(x.IsGreater(10));

            string text = "Koba";

            Console.WriteLine(text.IsNumber());
        }
    }

    static class MyCustomExtension
    {
        public static bool IsGreater(this int value, int number)
        {
            return value > number;
        }

        public static bool IsNumber(this string text)
        {
            return int.TryParse(text, out var result);
        }
    }
}
