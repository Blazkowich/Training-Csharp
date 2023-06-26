namespace LambdaExpresion
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddTwoNumbers(5, 7));
            Console.WriteLine(AddTWoNumbersFaster(5, 7));

            SayHi();
            Animals dog = new Animals();
            dog.Name = "Max";
            Console.WriteLine(dog.Name);
        }

        public static void SayHi() => Console.WriteLine("Welcome back Welter");

        public static int AddTWoNumbersFaster(int x, int y) => x + y;

        public static int AddTwoNumbers(int x, int y)
        {
            return x + y;
        }
    }

    class Animals
    {
        public Animals() => Console.WriteLine("A new Animal has been created");

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private string name;

        public string Name
        {
            get => name;
            set => name = value;
        }
    }
}
