namespace _10Head;

class Program
{
    static void Main(string[] args)
    {
        int[][] jaggedArrayOne = new int[3][];

        jaggedArrayOne[0] = new int[5] { 0, 1, 2, 3, 4 };
        jaggedArrayOne[1] = new int[5] { 5, 6, 7, 8, 9};
        jaggedArrayOne[2] = new int[5] { 10, 11, 12 ,13, 14};

        foreach (var item in jaggedArrayOne[0])
        {
            Console.WriteLine(item);
        }
    }
}

