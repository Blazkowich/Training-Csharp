using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        string test = "ieieueieoeijeikei";
        Dictionary<char, int> name = new Dictionary<char, int>();

        foreach (char i in test)
        {
            if (!name.ContainsKey(i))
                name[i] = 0;
                
            name[i]++;
        }

        foreach (char key in test)
        { 

            if (name[key] == 1)
            {
                Console.WriteLine(key);
                break;
            }
        }
    }
}
