// Problem 4. Hexadecimal to decimal

// Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class HexadecmalToDecimal
{
    static void Main()
    {
        Console.Write("Please, enter a hexadecimal number: ");
        string hexNumber = Console.ReadLine();

        // conversion using the embedded funcionality
        int decNumber = Convert.ToInt32(hexNumber, 16);
        Console.Write("\nConverted using the embedded funcionality: {0}", decNumber);
        Console.WriteLine();

        // conversion using the ConvertToDec(string number, int baseFrom) method from problem 7
        Console.Write("Converted using method called from problem 7: {0}", ConvertFromAnyNumSystem.ConvertToDec(hexNumber, 16));
        Console.WriteLine("\n");
    }
}

