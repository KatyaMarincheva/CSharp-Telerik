// Problem 1. Decimal to binary

// Write a program to convert decimal numbers to their binary representation.

using System;
using System.Text;

class DecimalToBinary
{
    static void Main()
    {

        Console.Write("Please, enter a decimal number:");
        int input = int.Parse(Console.ReadLine());
        int number = input; // we need a second copy, as after the divisions below the first one won't be equal to the input

        // custom conversion method
        StringBuilder list = new StringBuilder();
        while (input != 0)
        {
            list.Append(input % 2);
            input /= 2;
        }

        Console.WriteLine("\nConverted using custom method:");
        for (int i = list.Length - 1; i > -1; i--)
        {
            Console.Write(list[i]);
        }
        Console.WriteLine();

        // conversion using the embedded functionality 
        Console.WriteLine("\nConverted using embedded functionality: \n{0}", Convert.ToString(number, 2));
        Console.WriteLine();

        // conversion using the DecimalToBase(long decimalNumber, int numeralSystem) method from problem 7
        Console.WriteLine("Converted using method called from problem 7: \n{0}", ConvertFromAnyNumSystem.DecimalToBase(number, 2));
        Console.WriteLine();
    }
}

