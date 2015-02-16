// Problem 4. Binary search

/* Write a program, that reads from the console an array of N integers and an integer K, 
 * sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
 */

using System;
using System.Collections.Generic;
using System.Linq;

class BinarySearch
{
    static void Main()
    {
        // input array
        Console.WriteLine("Please enter a sequence of numbers, separated by space or comma: ");
        char[] delimiter = new char[] { ',', ' ' };
        int[] arr = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        // input K
        Console.Write("\nPlease enter a value for K: ");
        int K = int.Parse(Console.ReadLine());

        Array.Sort(arr);

        // sorted array
        Console.WriteLine("\nSorted array: \n{0}",string.Join(" ", arr));

        // applying the Array.BinarySearch() method
        int index = Array.BinarySearch(arr, K);
        Console.WriteLine("\nIndex calculated with the Array.BinarySearch() method: {0}", index);

        // availability and index of the number we are searching for
        if (K < arr.Min())
        {
            Console.WriteLine("\nThe array does not contain any value smaller or equal to K.\n");
        }
        else if (index >= 0)
        {
            Console.WriteLine("\nThis array includes the value {0} at index {1}.\n", K, index);
        }
        else
        {
            Console.WriteLine("\nThe largest number in the array which is smaller or equal to K is {0} at index {1}.\n", arr.Max(), arr.Length -1);
        }
    }
}

