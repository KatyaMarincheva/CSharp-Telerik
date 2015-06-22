// Problem 8. Binary short

// Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;

class BinaryShort
{
    static void Main()
    {
        // input
        Console.Write("Enter a number in interval [{0}; {1}]: ", short.MinValue, short.MaxValue);
        short number = short.Parse(Console.ReadLine());
        Console.WriteLine("\n{0} to binary => {1}\n", number, ShortToBinary(number));
    }
    static string ShortToBinary(short number)
    {
        string binary = string.Empty; // empty string
        for (int i = 15; i >= 0; i--)
        {
            binary += ((number % 2) & 1); // adding 1 or 0 to the binary string, depending on the number % 2 result
            number >>= 1; // instead of dividing the number - moving it one position to the right
            if (i % 4 == 0) binary = " " + binary;
        }
        // we will extract the digits in reversed order, so we need to reverse the order back to the correct one
        char[] result = binary.ToCharArray();
        Array.Reverse(result); 
        string output = string.Join("", result);
        return output;
    }
}

