// Problem 7. Selection sort

// Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
// Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
//find the smallest from the rest, move it at the second position, etc.


using System;
using System.Collections.Generic;
using System.Linq;

class SelectionSort
{
    static void Main()
    {
        // input
        Console.WriteLine("Please enter a sequence of numbers - all in one line, separated by a space:");
        string input = Console.ReadLine();
        string[] n = input.Split(' ');

        // filling the int array with the parsed input string elements
        int[] array = new int[n.Length];
        for (int i = 0; i < n.Length; i++)
        {
            array[i] = int.Parse(n[i]);
        }

        // declaring two lists
        List<int> tempList = array.ToList(); // initial int array converted into this list
        List<int> sorted = new List<int>(); // sordted list - to accomodate the sorted numbers from the above tempList

        while (tempList.Count != 0)
        {
            tempList.Min(); // finding tempList monimal value
            sorted.Add(tempList.Min()); // adding it to the sorted list
            tempList.Remove(tempList.Min()); // removing it from tempList

            // and retsrating the above, until tempList.Count == 0
        }

        // printing the sorted array
        Console.WriteLine("\nHere are the same numbers sorted: \n{0}\n", string.Join(" ", sorted));
    }
}

