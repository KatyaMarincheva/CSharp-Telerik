// Problem 24. Order words

// Write a program that reads a list of words, 
// separated by spaces and prints the list in an alphabetical order.

using System;
using System.Text.RegularExpressions;

class OrderWords
{
    static void Main()
    {
        // input
        Console.WriteLine("Please, enter below a list of words, separated by spaces: ");
        char[] delimiter = new char[] { ' ' };
        string[] words = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

        // sorting
        Array.Sort(words);

        // printing
        var sorted = string.Join(" ", words);
        Console.WriteLine("\nSorted list of words:");
        Console.WriteLine(sorted);
        Console.WriteLine();
    }
}

