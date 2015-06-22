// Problem 18.* Remove elements from array

/* Write a program that reads an array of integers and removes from it a minimal number of elements 
 * in such a way that the remaining array is sorted in increasing order.
   Print the remaining sorted array.

Example:
input 	                        result
6, 1, 4, 3, 0, 3, 6, 4, 5 	    1, 3, 3, 4, 5
 */

using System;
using System.Collections.Generic;
using System.Linq;

class IncreasingSubset
{
    // declarations
    static int[] arr;
    static int[] maxSubset = new int[1];
    static void Main()
    {
        // input array
        Console.WriteLine("Please enter a sequence of numbers, separated by space or comma: ");
        char[] delimiter = new char[] { ',', ' ' };
        arr = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        List<int> subset = new List<int>(); // in this list we will be storing the current sequence
        MakeSubset(0, subset);

        // printing
        Console.WriteLine("Longest increasing sequence is:");
        for (int i = 0; i < maxSubset.Length; i++)
        {
            Console.Write("{0,3}", maxSubset[i]);
        }
        Console.WriteLine();
    }

    static void MakeSubset(int index, List<int> subset)
    {
        if (subset.Count > 1 && subset[subset.Count - 2] > subset[subset.Count - 1]) // if newly inserted elemet <= last element
            return; // sequence is broken, exit
        if (subset.Count >= maxSubset.Length)
        {
            maxSubset = new int[subset.Count]; // save new longest subset
            subset.CopyTo(maxSubset);

        }
        for (int i = index; i < arr.Length; i++) // try with next item
        {
            subset.Add(arr[i]); // add new item in subset

            // Console.WriteLine(string.Join(" ", subset)); // uncomment this line if you want to see what subsets are creared
            MakeSubset(i + 1, subset);
            subset.RemoveAt(subset.Count - 1); // remove last item

        }
    }
}
