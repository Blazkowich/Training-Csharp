using System.Diagnostics;
namespace delegates
{
    public delegate T DisplayInfo<T>(T value);
    class Program
    {
        static void Main(string[] args)
        {
            DisplayInfo<int> myNumber = new DisplayInfo<int>(DisplayValue);
            Console.WriteLine(myNumber(100));

            DisplayInfo<double> myDouble = new DisplayInfo<double>(DisplayValue);
            Console.WriteLine(myDouble(3.5));

            DisplayInfo<DateTime> myDate = new DisplayInfo<DateTime>(DisplayValue);
            Console.WriteLine(myDate(new DateTime(2010, 2, 28)));
        }

        public static T DisplayValue<T>(T value)
        {
            Console.WriteLine("Now We Are Accessing Variable Of Type " + value.GetType().Name);
            return value;
        }
    }
}
