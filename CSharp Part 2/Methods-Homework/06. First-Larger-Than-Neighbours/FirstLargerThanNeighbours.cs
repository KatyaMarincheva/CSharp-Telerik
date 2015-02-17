// Problem 6. First larger than neighbours

/* Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
   Use the method from the previous exercise.
 */

using System;
using System.Linq;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        // input array
        Console.WriteLine("Please enter a sequence of numbers, separated by space or comma: ");
        char[] delimiter = new char[] { ',', ' ' };
        int[] arr = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        FirstLarger(arr);
    }

    private static void FirstLarger(int[] arr)
    {
        int count = 0;
        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (LargerThanNeighbours.isLarger(arr, i))
            {
                Console.WriteLine("\nThe index of the first element in array that is larger than its neighbours is: {0}", i);
                count++;
                return;
            }
        }

        if (count == 0)
        {
            Console.WriteLine("\nThe index of the first element in array that is larger than its neighbours is: {0}", -1);
        }
    }


}

