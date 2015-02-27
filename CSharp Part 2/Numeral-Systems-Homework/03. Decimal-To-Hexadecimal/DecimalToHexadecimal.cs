// Problem 3. Decimal to hexadecimal

// Write a program to convert decimal numbers to their hexadecimal representation.

using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Please, enter a decimal number: ");
        long number = long.Parse(Console.ReadLine());

        // conversion using embedded functionality
        Console.Write("\nConverted using embedded functionality: {0:X}", number);
        Console.WriteLine();

        // conversion using the DecimalToBase(long decimalNumber, int numeralSystem) method from problem 7
        Console.Write("Converted using method called from problem 7: {0}", ConvertFromAnyNumSystem.DecimalToBase(number, 16));
        Console.WriteLine("\n");
    }
}

