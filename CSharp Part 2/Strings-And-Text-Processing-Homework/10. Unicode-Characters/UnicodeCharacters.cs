// Problem 10. Unicode characters

/*  Write a program that converts a string to a sequence of C# Unicode character literals.
    Use format strings.

Example:
input 	output
Hi! 	\u0048\u0069\u0021
 */

using System;

class UnicodeCharacters
{
    static void Main()
    {
        // input
        Console.Write("Please, enter a string: ");
        string input = Console.ReadLine();

        // converting chars to unicode literals
        foreach (char c in input)
        {
            Console.Write("\\u{0:x4}",(int)c);
        }
        Console.WriteLine();
    }
}

