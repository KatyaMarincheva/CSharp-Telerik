// Problem 4. Appearance count

/* Write a method that counts how many times given number appears in given array.
   Write a test program to check if the method is workings correctly.
 */

using System;
using System.Linq;

class AppearanceCount
{
    static void Main()
    {
        // input array
        Console.WriteLine("Please enter a sequence of numbers, separated by space or comma: ");
        char[] delimiter = new char[] { ',', ' ' };
        int[] array = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        Console.Write("Please, enter a number to search for: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("\nThe number {0} appears {1} times in the input array.\n", num, AppCount(array, num));
    }

    static int AppCount(int[] arr, int number)
    {
        // counting how many times number appears in the input array
        int result = arr.Count(n => n == number);

        return result;
    }  
}

