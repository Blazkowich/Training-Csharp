namespace _10Head;

class Program
{
    static void Main(string[] args)
    {
        string[,] array = new string[3, 3];

        for (var i =0;i<3;i++)
        {
            for (var j = 0; j<3;j++)
            {
                array[i, j] = $"Item{i}{j}";
            }
        }

        Console.WriteLine("\tColumn1 \tColumn2 \tColumn3");
        Console.WriteLine("\t-------- \t-------- \t--------");

        for (var i = 0; i < 3; i++)
        {
            Console.Write("Row " + (i+1));
            for(var j = 0; j < 3; j++)
            {
                Console.Write("\t");
                Console.Write(array[i,j]);
                Console.Write("\t");
                if(j==2)
                {
                    Console.WriteLine();
                }
                
            }
        }
        Console.WriteLine();

    }
}

