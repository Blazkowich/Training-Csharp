using System.Diagnostics;
namespace delegates
{
    public delegate void SayHiDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            SayHiDelegate sayHi = null;

            sayHi = new SayHiDelegate(SayHiEnglish);
            sayHi += new SayHiDelegate(SayHiRussian);
            sayHi += new SayHiDelegate(SayHiGerman);
            sayHi += new SayHiDelegate(SayHiGeorgian);

            sayHi();
        }

        public static void SayHiEnglish()
        {
            Console.WriteLine("Hello");
        }
        public static void SayHiRussian()
        {
            Console.WriteLine("Zdrastvuite");
        }
        public static void SayHiGerman()
        {
            Console.WriteLine("Hallo");
        }
        public static void SayHiGeorgian()
        {
            Console.WriteLine("Gamarjoba");
        }
    }
}
