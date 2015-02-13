// Problem 9. Frequent number
/*
    Write a program that finds the most frequent number in an array.

Example:
input 	result
4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 	4 (5 times)
 * 
 * */ 

using System;

class FrequentNumber
{
    static void Main()
    {
        // input
        Console.WriteLine("Please write a sequence of numbers, all in one line, separated by a space or comma: \n");
        string input = Console.ReadLine();
        char[] space = { ',', ' ' };
        string[] n = input.Split(space, StringSplitOptions.RemoveEmptyEntries);

        // filling the array with the parsed elements of the input string
        int[] array = new int[n.Length];
        for (int i = 0; i < n.Length - 1; i++)
        {
            array[i] = int.Parse(n[i]);
        }

        // sorting the array so that we can have all elements of equal values next to each other
        Array.Sort(array);

        // declaring the number we are searching for, its temp and best counts
        int number = 0;
        int count = 0;
        int bestCount = 0;

        // looping over the array and searching for equal values
        for (int i = 1; i < n.Length - 1; i++)
        {
            if (array[i] == array[i - 1])
            {
                count++;

                // we stp searching when we find a count of equal values, exceeding all previous counts
                if (count > bestCount)
                {
                    bestCount = count;
                    // and our number is the array emement at current i-postion
                    number = array[i];
                }
            }

            // else, if the current count of equal values is not higher than the previously registered one - we restart the counting
            else
            {
                count = 1;
            }
        }

        // printing the result
        Console.WriteLine("\nThe maximal sequence is: number {0} repeated {1} times", number, bestCount);
    }
}

