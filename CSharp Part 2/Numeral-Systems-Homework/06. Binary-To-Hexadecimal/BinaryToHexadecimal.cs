// Problem 6. Binary to hexadecimal

// Write a program to convert binary numbers to hexadecimal numbers (directly).


using System;
using System.Collections.Generic;
using System.Text;

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.Write("Please, enter a binary number: ");
        string binary = Console.ReadLine();

        // conversion using the embedded funcionality
        string hexNumber = Convert.ToInt32(binary, 2).ToString("X");
        Console.Write("\nConverted using the embedded funcionality: {0}", hexNumber);
        Console.WriteLine();

        // conversion using the ConvertToDec(string number, int baseFrom) and DecimalToBase(long decimalNumber, int numeralSystem) methods from problem 7
        Console.Write("Converted using method called from problem 7: {0}", ConvertFromAnyNumSystem.
            DecimalToBase(ConvertFromAnyNumSystem.ConvertToDec(binary, 2), 16));
        Console.WriteLine();

        // both methods above pass through decimal representation of the number first
        // the one below doesn't:
        // conversion using the custom, direct hex to binary method
        StringBuilder hexNum = BinaryToHexString(binary);
        Console.Write("Converted using custom, direct binary to hex method: {0}", hexNum);
        Console.WriteLine("\n");
    }

    // convert every 4-chars substring of the binary number into a hex char
    private static StringBuilder BinaryToHexString(string binary)
    {
        StringBuilder hexNum = new StringBuilder();

        for (int i = 0; i < binary.Length; i += 4)
        {
            hexNum.Append(binaryToHexChar[binary.Substring(i, 4)]);
        }
        return hexNum;
    }

    // dictionary linking every 4-chars binary string representation to the respective hexadecimal char 
    private static readonly Dictionary<string, char> binaryToHexChar = new Dictionary<string, char> 
    {
    { "0000", '0' },
    { "0001", '1' },
    { "0010", '2' },
    { "0011", '3' },
    { "0100", '4' },
    { "0101", '5' },
    { "0110", '6' },
    { "0111", '7' },
    { "1000", '8' },
    { "1001", '9' },
    { "1010", 'A' },
    { "1011", 'B' },
    { "1100", 'C' },
    { "1101", 'D' },
    { "1110", 'E' },
    { "1111", 'F' }
    };
}

