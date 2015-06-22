// Problem 2. Reverse string

/* Write a program that reads a string, reverses it and prints the result at the console.

Example:
input 	output
sample 	elpmas
 */

using System;
using System.Linq;

class ReverseString
{
    static void Main()
    {
        // input
        Console.WriteLine("Please, enter a string: ");
        string input = Console.ReadLine();

        // reversing and printing
        Console.WriteLine(string.Join("", input.Reverse()));
    }
}

