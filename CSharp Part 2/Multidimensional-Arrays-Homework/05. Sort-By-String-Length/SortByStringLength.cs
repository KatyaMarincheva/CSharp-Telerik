// Problem 5. Sort by string length

// You are given an array of strings. Write a method that sorts the array 
// by the length of its elements (the number of characters composing them).

using System;

class SortByStringLength
{
    static void Main()
    {
        Console.WriteLine("Please enter a sequence of words all in one line, separated by space: ");
        char[] delimiter = new char[] { ',', ' ' };
        string[] arr = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

        Array.Sort(arr, (x, y) => x.Length.CompareTo(y.Length));

        Console.WriteLine("\nSorted string array: ");
        foreach (string str in arr)
        {
            Console.Write("{0} ", str);
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

