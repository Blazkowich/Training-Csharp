using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_and_Second_max_numbers_in_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            nums.Add(1);
            nums.Add(2);
            nums.Add(3);
            nums.Add(4);
            int maxnum = nums[0];
            int secondnum = 0;
            int minnum = 0;
            foreach (int num in nums.Skip(1))
            {
                if (num > maxnum)
                {
                    maxnum = num;
                    if ((num > minnum) && (num < maxnum))
                    {
                        secondnum = num;
                    }
                    secondnum += 1;
                }
            }
            Console.WriteLine("Max Number is :" + maxnum);
            Console.WriteLine("Second Max Number is : " + secondnum);
        }
    }
}
