using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_and_age
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("Nice to meet you {0}, My name is C#, How old are you?", name);
            int.TryParse(Console.ReadLine(), out int age);
            if (age == 0)
                Console.WriteLine("Wrong Entered type of data");
            else
                Console.WriteLine("{0} Good, As for me i was born on 2002, Which makes me {1} years old.", age,DateTime.Now.Year - 2002);
        }
    }
}
