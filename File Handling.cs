using System.IO;
namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Directory For Text Document File
            string file = @"_______";

            //Directory For Folder
            Directory.CreateDirectory(@"______");

            //Writer Module
            StreamWriter sw = new StreamWriter(file);

            //Reader Module
            StreamReader sr = new StreamReader(file, true);

            //Caling Writer Module
            sw.WriteLine("Koba");
            sw.WriteLine("Buchukuri");

            //Calling Reader Module
            Console.WriteLine(sr.ReadToEnd());
            Console.WriteLine("File Ended");

            //Close Function
            sw.Close();
            sr.Close(); 

        }
    }
}
