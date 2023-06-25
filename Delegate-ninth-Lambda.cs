namespace lambda
{
    delegate void DisplayMessage();
    delegate int Multiply(int n);
    class Program
    {
        static void Main(string[] args)
        {
            // Multiply MultiplyNumber = delegate (int n) { { return n * 3; }; };
            Multiply MultiplyNumber = n => n * 3;
            Console.WriteLine(MultiplyNumber(10));

            //DisplayMessage Message = delegate { Console.WriteLine("Hi From Anonymous"); };
            DisplayMessage Message = () => Console.WriteLine("Hi From Anonymous");
            Message();
        }
    }
}
