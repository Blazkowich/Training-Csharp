using System.Collections;
namespace NonGenericArray;
class Program
{
    static void Main(string[] args)
    {
        // Creating
        bool[] boolArray = new bool[4];
        boolArray[0] = false;
        boolArray[1] = false;
        boolArray[2] = false;
        boolArray[3] = true;

        BitArray firstBitArray = new BitArray(4);
        BitArray secondBitArray = new BitArray(4);


        //Setting Value
        firstBitArray.Set(0, false);
        firstBitArray.Set(1, false);
        firstBitArray.Set(2, false);
        firstBitArray.Set(3, true);

        foreach (var item in firstBitArray)
        {
            Console.WriteLine(item);
        }

        // And - Or - Not
        Console.WriteLine();
        BitArray result = new BitArray(4);

        result = firstBitArray.And(secondBitArray);
        foreach (var item in result)
        {
            Console.WriteLine("And Result - " + item);
        }
        Console.WriteLine();
        result = firstBitArray.Or(secondBitArray);
        foreach (var item in result)
        {
            Console.WriteLine("Or Result - " + item);
        }
        Console.WriteLine();
        result = firstBitArray.Not();
        foreach (var item in result)
        {
            Console.WriteLine("Not Result - " + item);
        }

    }
}
