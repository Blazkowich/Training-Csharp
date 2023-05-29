using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_unique_character
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "ieiez";
            int counter = 0;
            foreach (var i in text)
            {
                //counter += 1;
                int seccounter = 0;
                foreach (var j in text)
                {
                    counter += 1;
                    if (i == j)
                    {
                        seccounter += 1;
                    }
                    if (seccounter > 1)
                    {
                        break;
                    }
                }
                if (seccounter == 1)
                {
                    Console.WriteLine("Unique Character Is : " + i);
                    Console.WriteLine("Index of Character Is : " + text.IndexOf(i));
                    break;
                }
            }
        }
    }
}
