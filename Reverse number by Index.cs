using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_number_by_index
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int startIndex = 0;
            int endIndex = numbers.Length - 1;

            while (startIndex < endIndex)
            {
                int temp = numbers[startIndex];
                numbers[startIndex] = numbers[endIndex];
                numbers[endIndex] = temp;
                startIndex++;
                endIndex--;
            }

            foreach (int number in numbers)
            {
                Console.WriteLine(number + " ");
            }

        }
    }
}
