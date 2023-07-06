using System;

public class DecimalBinaryConverter
{
    public static string Convert(int n)
    {
        if (n >= 0)
            return ConvertPositive(n);
        else
            return ConvertNegative(n);
    }

    private static string ConvertPositive(int n)
    {
        string result = "";

        while (n > 0)
        {
            result = (n % 2) + result;
            n = n / 2;
        }

        while (result.Length < 8)
            result = "0" + result;

        return result;
    }

    private static string ConvertNegative(int n)
    {
        string positiveBinary = ConvertPositive(-n);
        string flippedBits = "";

        foreach (char bit in positiveBinary)
        {
            if (bit == '0')
            {
                flippedBits += "1";
            }
            else
            {
                flippedBits += "0";
            }
        }
        return flippedBits;
    }

    public static int ReverseConvert(string binary)
    {
        bool isNegative = binary[0] == '1';

        if (isNegative)
        {
            binary = FlipBits(binary.Substring(1));
            int decimalValue = ReverseConvertPositive(binary);
            return -decimalValue;
        }
        else
        {
            return ReverseConvertPositive(binary.Substring(1));
        }
    }

    private static int ReverseConvertPositive(string binary)
    {
        int decimalValue = 0;
        int power = binary.Length - 1;

        foreach (char digit in binary)
        {
            decimalValue += (digit - '0') * (1 << power);
            power--;
        }

        return decimalValue;
    }

    private static string FlipBits(string binary)
    {
        string flippedBits = "";

        foreach (char bit in binary)
        {
            if (bit == '0')
                flippedBits += '1';
            else
                flippedBits += '0';
        }

        return flippedBits;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Convert(2));
        Console.WriteLine(Convert(-2));

        Console.WriteLine();

        Console.WriteLine(ReverseConvert(Convert(2)));
        Console.WriteLine(ReverseConvert(Convert(-2)));


    }
}
