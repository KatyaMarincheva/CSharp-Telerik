// Problem 5. Sort by string length

// You are given an array of strings. Write a method that sorts the array 
// by the length of its elements (the number of characters composing them).

using System;
using System.Collections.Generic;
using System.Linq;

class SortByStringLength
{
    static void Main()
    {
        // string array input - can be a sentence with a full stop at the end, 
        // the code below will remove the full stp as well, and sort the words only
        Console.WriteLine("Please enter a sequence of words all in one line, separated by space: ");
        char[] delimiter = new char[] { ',', ' ', '.' };
        string[] arr = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

        // both Array.Sort() and arr.OrderBy() methods can be used for sorting the array
        // you can test them if you uncomment one and comment the other

        //Array.Sort(arr, (x, y) => x.Length.CompareTo(y.Length));
        var query = arr.OrderBy(item => item.Length);
        string[] sorted = query.ToArray();

        // printing
        Console.WriteLine("\nSorted string array: ");
        foreach (string str in sorted)
        {
            Console.Write("{0} ", str);
        }

        Console.WriteLine();
        Console.WriteLine();
    }
}

