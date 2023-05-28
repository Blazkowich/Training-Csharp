using System;
using System.IO;
namespace File_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            string parentDirectory = @"C:\Languages";
            Directory.CreateDirectory(parentDirectory);

            int count = Enum.GetNames(typeof(Languages)).Length;

            for (int i = 0; i < count; i++)
            {
                string language = Enum.GetValues(typeof(Languages)).GetValue(i).ToString();
                string languageDirectory = Path.Combine(parentDirectory, language);
                Directory.CreateDirectory(languageDirectory);

                string filePath = Path.Combine(languageDirectory, "log.txt");
                using (StreamWriter wr = new StreamWriter(filePath))
                {

                    wr.WriteLine("File Number : " + i + " Created On " + DateTime.Now);
                    wr.Close();
                }
            }
        }
    }

    enum Languages
    {
        English,
        German,
        Polish,
        Francian,
        Espanian,
        Dutch,
        Georgian,
        Turkish,
        Russian,
        Japanese,
        Italianese
    }
}
