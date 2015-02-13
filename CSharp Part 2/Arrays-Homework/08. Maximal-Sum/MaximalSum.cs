// Problem 8. Maximal sum

/* Write a program that finds the sequence of maximal sum in given array.

Example:
input 	                            result
2, 3, -6, -1, 2, -1, 6, 4, -8, 8 	2, -1, 6, 4

    Can you do it with only one loop (with single scan through the elements of the array)?
 */

using System;

class MaxSumSequence
{
    static void Main()
    {
        // value for N?
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        // filling the array with N elemets
        for (int index = 0; index < n; index++)
        {
            Console.Write("Enter element {0}: ", index);
            arr[index] = int.Parse(Console.ReadLine());
        }

        // both temporay and final sum are equal to the first array element
        int maxSum = int.MinValue, currentSum = 0;

        // summing sequence start and end positions are still 0
        int start = 0, startTemp = 0, end = 0;

        // looping once over all array elemenents
        for (int i = 0; i < arr.Length; i++)
        {
            // if the current sum is lower than 0 or equal to 0 - reset values: 
            // currentSum = 0; startTemp = i; or shortly we start over
            if (currentSum <= 0)
            {
                currentSum = 0;
                startTemp = i;
            }

            // adding every next array element
            currentSum += arr[i];

            // if we have a current sum higher than any previous sum, we stop searching
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                start = startTemp;
                end = i;
            }
        }

        // and we print the chosen sequence of maximal sum array elements
        Console.Write("\nThe sequence with maximal sum is: ");
        for (int i = start; i <= end; i++)
        {
            Console.Write("{0} ", arr[i]);
        }
        Console.WriteLine();
    }
}