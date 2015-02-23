//Problem 11. Format number

/*  Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
    Format the output aligned right in 15 symbols.
 */

using System;

class FormatNumber
{
    static void Main()
    {
        // input
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        // formating
        Console.WriteLine("Decimal: {0,15:D}", num);
        Console.WriteLine("Hexadecimal: {0,15:X}", num);
        Console.WriteLine("Percentage: {0,15:P}", num);
        Console.WriteLine("Scientific notation: {0,15:E}", num);
    }
}

