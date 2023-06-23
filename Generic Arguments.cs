namespace recursiveMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayPlayerInformation("john");
            DisplayPlayerInformation(2);
            DisplayPlayerInformation(2.5);
            DisplayPlayerInformation(DateTime.Now);

            var playerInfo = (7, "Ronaldo", 55);
            DisplayPlayerInformation(playerInfo);
        }

        public static void DisplayPlayerInformation<T>(T info)
        {
            Console.WriteLine(info);
        }
    }
}
