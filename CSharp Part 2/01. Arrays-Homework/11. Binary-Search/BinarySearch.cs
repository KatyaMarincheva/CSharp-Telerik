// Problem 11. Binary search

// Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;

class BinarySearch
{
    static void Main()
    {
        // input
        // value for N?
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        // array of N elements
        int[] array = new int[n];
        for (int index = 0; index < n; index++)
        {
            Console.Write("Enter element {0}: ", index);
            array[index] = int.Parse(Console.ReadLine());
        }

        // element to search for
        Console.Write("Enter element to search for: ");
        int element = int.Parse(Console.ReadLine());

        //sorting the array
        Array.Sort(array);

        // displaying the sorted array
        Console.WriteLine(string.Join(" ", array));

        // applying the BinarySearch method
        Console.WriteLine(BinarySearchIterative(array, element, 0, array.Length)); 
    }

    public static object BinarySearchIterative(int[] inputArray, int key, int min, int max)
    {
        while (min <= max)
        {
            // we keep cutting the array into halves
            int mid = (min + max) / 2;

            // element index found - if the element is found multiple times in the array, 
            // this method returns the first position at which the element is found
            if (key == inputArray[mid])
            {
                return mid;
            }

            // searching in the first half of the array
            else if (key < inputArray[mid])
            {
                max = mid - 1;
            }

            // or into the second half
            else
            {
                min = mid + 1;
            }
        }

        // in case the element is not found in this array
        return "Not found.";
    }
}


