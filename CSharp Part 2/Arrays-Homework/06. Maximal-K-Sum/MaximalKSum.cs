// Problem 6. Maximal K sum

// Write a program that reads two integer numbers N and K and an array of N elements from the console.
// Find in the array those K elements that have maximal sum.

using System;
using System.Collections.Generic;
using System.Linq;  

class MaximalKSum
{
    static void Main()
    {
        // input
        Console.WriteLine("Please enter a sequence of numbers - all in one line, separated by a space:");
        string input = Console.ReadLine();
        char[] space = { ' ' };
        string[] n = input.Split(space, StringSplitOptions.RemoveEmptyEntries);

        int[] array = new int[n.Length];
        for (int i = 0; i < n.Length; i++)
        {
            array[i] = int.Parse(n[i]);
        }

        // sorting the initial array so that we can see the same elements in increasing order
        Array.Sort(array);
        Console.WriteLine("\nSorted array: {0}\n", string.Join(" ", array));

        // how many element will we be summing?
        Console.WriteLine("How many array elements wold you like to sum?");
        int K = int.Parse(Console.ReadLine());

        // orders the array in descending order, cuts K elemets from it, and stores them into a new array: highestK
        var highestK = array.OrderByDescending(a => a).Take(K);
        
        // displays the elemenst in the new array highestK
        Console.WriteLine("\nHere are the {0} elements with the highest values, which will give the maximal sum: \n{1}\n", K, string.Join(" ", highestK)); 
    }
}

