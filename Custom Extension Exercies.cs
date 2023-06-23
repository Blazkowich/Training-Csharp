namespace recursiveMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime myDate = new DateTime(2000, 11, 1);
            Console.WriteLine(myDate.MyCustomFormat());
        }
    }

    static class MyCustomExtension
    {
        public static string MyCustomFormat(this DateTime date)
        {
            return string.Format("{0:dddd dd \nMMM yyyy}", date);
        }
    }
}
