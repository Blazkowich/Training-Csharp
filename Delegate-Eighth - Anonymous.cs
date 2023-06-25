using System.Globalization;

namespace AnonymousMethods
{
    delegate void DisplayInfo();
    delegate void DisplayInfoBasedOnNumber(int number);
    class Program
    {
        static void Main(string[] args)
        {
            DisplayInfo normalDelegate = new DisplayInfo(GetInformation);
            normalDelegate();

            DisplayInfoBasedOnNumber OneParamDelegate = new DisplayInfoBasedOnNumber(GetInformation);
            OneParamDelegate(10);

            Console.WriteLine("----------------");

            DisplayInfo normalDelegateAnonymous = delegate { Console.WriteLine("Hi From Anonymous"); };
            normalDelegateAnonymous();

            DisplayInfoBasedOnNumber oneParameterDelegateAnonymous = delegate (int x) { Console.WriteLine("Hi from Parametred anonymous " + x); };
            oneParameterDelegateAnonymous(10);

        }

        public static void GetInformation()
        {
            Console.WriteLine("Delegate witho no parameter");
        }
        public static void GetInformation(int x)
        {
            Console.WriteLine("Delegate With One Parameter " + x);
        }
    }
}
