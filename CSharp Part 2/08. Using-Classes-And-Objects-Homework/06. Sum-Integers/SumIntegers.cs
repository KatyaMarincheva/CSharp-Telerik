// Problem 6. Sum integers

/* You are given a sequence of positive integer values written into a string, separated by spaces.
   Write a function that reads these values from given string and calculates their sum.

Example:
input 	            output
"43 68 9 23 318" 	461
*/
using System;
using System.Linq;

class SumIntegers
{
    static void Main()
    {
        // input array
        Console.WriteLine("Please enter a sequence of numbers, separated by space or comma: ");
        char[] delimiter = new char[] { ' ' };
        int[] array = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        SumArray(array);
    }

    private static void SumArray(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        Console.WriteLine("The sum of all array elements is: {0}", sum);
    }
}

