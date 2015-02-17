// Problem 5. Larger than neighbours

// Write a method that checks if the element at given position in given array of integers
// is larger than its two neighbours (when such exist).

using System;
using System.Linq;

public class LargerThanNeighbours
{
    static void Main()
    {
        // input array
        Console.WriteLine("Please enter a sequence of numbers, separated by space or comma: ");
        char[] delimiter = new char[] { ',', ' ' };
        int[] arr = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        // input position
        Console.Write("\nPlease, enter a position to check for: ");
        int position = int.Parse(Console.ReadLine());

        // print result
        Console.Write("\nThe number at position {0} is ", position);
        Console.WriteLine(isLarger(arr, position) ? "larger than its neighbours." : 
            "not larger than its neighbours"); // apply the isLarger method
    }

    public static bool isLarger(int[] arr, int i)
    {
        // compare the number at the specified position with its neighbours
        if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
        {
            return true;
        }
        else
        {
            return false;
        }
    }    
}   


