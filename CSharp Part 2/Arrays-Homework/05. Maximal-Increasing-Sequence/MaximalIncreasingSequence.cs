// Problem 4. Maximal sequence
 
// Write a program that finds the maximal sequence of equal elements in an array.

using System;
using System.Collections.Generic;

class MaximalSequence
{
    static void Main()
    {
        // input
        Console.WriteLine("Please enter a sequence of numbers - all in one line, separated by a space:");
        string input = Console.ReadLine();
        char[] space = { ',', ' ' };
        string[] n = input.Split(space, StringSplitOptions.RemoveEmptyEntries);

        int[] array = new int[n.Length];
        for (int i = 0; i < n.Length; i++)
        {
            array[i] = int.Parse(n[i]);
        }

        // declarations
        int number = 0;
        int count = 0;
        int bestCount = 0;

        // logic - searching for the longest increasing sequence
        for (int i = 0; i < array.Length - 1; i++)
        {
            count = 1;
            int j = i + 1;
            int k = i;
            while (array[k] + 1 == array[j])
            {
                count++;
                j++;
                k++;
                if (j >= array.Length)
                {
                    break;
                }
            }
            if (count > bestCount)
            {
                bestCount = count;
                number = i;
            }
        }

        // printing
        for (int i = number; i <= number + bestCount - 1; i++)
        {
            Console.Write("{0} ", array[i]);
        }
    }
}


