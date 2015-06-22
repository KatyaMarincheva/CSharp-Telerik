/*Problem 4. Maximal sequence

Write a program that finds the maximal sequence of equal elements in an array.*/

using System;

class MaximalSequence
{
    static void Main()
    {
        // input
        Console.WriteLine("Please write a sequence of numbers, all in one line, separated by a space: \n");
        string input = Console.ReadLine();
        string[] n = input.Split(' ');

        // filling the array with the parsed elements of the input string
        int[] array = new int[n.Length];
        for (int i = 0; i < n.Length - 1; i++)
        {
            array[i] = int.Parse(n[i]);
        }

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
        Console.WriteLine("The maximal sequence is: number {0} repeated {1} times", number, bestCount);
    }
}