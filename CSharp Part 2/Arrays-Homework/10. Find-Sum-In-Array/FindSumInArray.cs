// Problem 10. Find sum in array

/* Write a program that finds in given array of integers a sequence of given sum S (if present).

Example:
array 	                S 	    result
4, 3, 1, 4, 2, 5, 8 	11 	    4, 2, 5
 */

using System;

class FindSumInArray
{
    static void Main()
    {
        // input
        // value for N
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        // array of N elements
        int[] arr = new int[n];
        for (int index = 0; index < n; index++)
        {
            Console.Write("Enter element {0}: ", index);
            arr[index] = int.Parse(Console.ReadLine());
        }

        // value for S
        Console.Write("Enter a value for sum  S: ");
        int s = int.Parse(Console.ReadLine());

        // declarations
        int sum = 0;
        bool solution = false;

        // logic: summing i with all numbers in the range after i
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                sum += arr[j];

                // if we reach the intended sum, we print the sequence between i and the value j in the range of numbers after i
                if (sum == s)
                {
                    solution = true;
                    Console.Write("The following sequence has the sum of {0}: ", s);
                    for (int print = i; print <= j; print++)
                    {
                        Console.Write("{0} ", arr[print]);
                    }
                    Console.WriteLine();
                }
            }
            sum = 0;
        }
        Console.WriteLine();
        // result to print if there is no sequence summing to the intended number
        if (!solution)
        {
            Console.WriteLine("There is no sequnce with the sum of {0}!\n", s);
        }
    }
}

