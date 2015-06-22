// Problem 2. Binary to decimal

// Write a program to convert binary numbers to their decimal representation.

using System;

class BinaryToDecimal
{
    static void Main()
    {
        // input
        Console.WriteLine("Please, enter a binary number:");
        string number = Console.ReadLine();

        // custom conversion method
        int decNumber = 0;
        int index = 0;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            decNumber += (int)(int.Parse(number[i].ToString()) * Math.Pow(2, index));
            index++;
        }
        Console.WriteLine("\nConverted using the custom method: {0}", decNumber);

        // conversion using embedded functionality
        decNumber = Convert.ToInt32(number, 2);
        Console.WriteLine("\nConverted using the embedded functionality: {0}\n", decNumber);
    }
}

