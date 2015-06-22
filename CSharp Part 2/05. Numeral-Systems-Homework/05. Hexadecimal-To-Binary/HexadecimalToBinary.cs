// Problem 5. Hexadecimal to binary

// Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;
using System.Collections.Generic;
using System.Text;

class HexadecimalToBinary
{
    static void Main()
    {
        Console.Write("Please, enter a hexadecimal number: ");
        string hexNumber = Console.ReadLine();

        // conversion using the embedded funcionality
        string binary = Convert.ToString(Convert.ToInt32(hexNumber, 16), 2);
        Console.Write("\nConverted using the embedded funcionality: {0}", binary);
        Console.WriteLine();

        // conversion using the ConvertToDec(string number, int baseFrom) and DecimalToBase(long decimalNumber, int numeralSystem) methods from problem 7
        Console.Write("Converted using method called from problem 7: {0}", ConvertFromAnyNumSystem.
            DecimalToBase(ConvertFromAnyNumSystem.ConvertToDec(hexNumber, 16), 2));

        // both methods above pass through decimal representation of the number first
        // the one below doesn't:
        // conversion using the custom, direct hex to binary method
        Console.Write("\nConverted using custom, direct hex to binary method: {0}", HexStringToBinary(hexNumber));
        Console.WriteLine("\n");
    }

    public static string HexStringToBinary(string hex)
    {
        StringBuilder result = new StringBuilder();
        foreach (char c in hex)
        {
            result.Append(hexCharacterToBinary[char.ToLower(c)]);
        }
        return result.ToString();
    }

    // dictionary linking every hexadecimal char to the respective 4-chars binary string representation
    private static readonly Dictionary<char, string> hexCharacterToBinary = new Dictionary<char, string> 
    {
    { '0', "0000" },
    { '1', "0001" },
    { '2', "0010" },
    { '3', "0011" },
    { '4', "0100" },
    { '5', "0101" },
    { '6', "0110" },
    { '7', "0111" },
    { '8', "1000" },
    { '9', "1001" },
    { 'a', "1010" },
    { 'b', "1011" },
    { 'c', "1100" },
    { 'd', "1101" },
    { 'e', "1110" },
    { 'f', "1111" }
    };
}

