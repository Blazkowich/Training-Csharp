namespace recursiveMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\LEGION Y520\Desktop\EncDecr";
            Console.WriteLine("Non Recursive");
            DisplayFolder(path, 0);
            Console.WriteLine();
            Console.WriteLine("Recursive");
            DisplayFolders(path, 0);
        }

        public static void DisplayFolder(string path, int indent)
        {
            foreach (var folder in Directory.GetDirectories(path))
            {
                Console.WriteLine($"{new string(' ', indent)} {Path.GetFileName(folder)}");
            }
        }

        public static void DisplayFolders(string path, int indent)
        {
            foreach (var folder in Directory.GetDirectories(path))
            {
                Console.WriteLine($"{new string(' ', indent)} {Path.GetFileName(folder)}");
                DisplayFolders(folder, indent+3);
            }
        }
    }
}
