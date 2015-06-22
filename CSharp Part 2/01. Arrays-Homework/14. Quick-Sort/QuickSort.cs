//Problem 14. Quick sort

//  Write a program that sorts an array of integers using the Quick sort algorithm.

using System;

class QuickSortAlgorithm
{
    static void SwapElements(string[] arr, int first, int second)
    {
        // swapping the values at first and second position
        // first and second can be any two neighboring positions
        string temp = arr[first];
        arr[first] = arr[second];
        arr[second] = temp;
    }

    static int Partition(string[] arr, int left, int right, int pivotIndex)
    {
        // declaring a string-represented number "pivot", at position "pivotIndex"
        string pivot = arr[pivotIndex];

        // pivot switches places with the number to the right
        SwapElements(arr, pivotIndex, right);

        // store index is where we will store any number found below to ne smaller than pivot
        int storeIndex = left;
        for (int i = left; i < right; i++)
        {
            // the string.Compare( firstString, secondString ) method, returns an integer (-1, 0, 1) 
            // that indicates the relative position of the strings in the sort order

            // namely, if the value of arr[i] is lower, arr[i] goes to the left of pivot 
            // (storeIndex = left, no value, just to the left of)
            if (string.Compare(arr[i], pivot) <= 0) 
            {
                SwapElements(arr, storeIndex, i);
                storeIndex++; // counts how many numbers we have moved to the left of pivot
            }
        }

        // storeIndex moves to the right, and we get it's new position
        SwapElements(arr, storeIndex, right);
        return storeIndex;
    }

    static void QuickSort(string[] arr, int left, int right)
    {
        if (left >= right)
        {
            return; // no need to change the pivot index position if the number to the right is smaller
        }
        
        // calculating pivotIndex
        int pivotIndex = left + (right + 1 - left) / 2;

        // pivotIndex changes after the Partition method is applied
        int pivotNewIndex = Partition(arr, left, right, pivotIndex);

        // we re-apply the QuickSort method (the calculations of the pivotIndex

        // for positions: left and (pivotNewIndex - 1)
        QuickSort(arr, left, pivotNewIndex - 1);

        // for positions: (pivotNewIndex + 1) and right
        QuickSort(arr, pivotNewIndex + 1, right);
    }

    static void Main()
    {
        // value for N?
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        // initializing a STRING array of N numbers represented as strings
        string[] arr = new string[n];
        for (int index = 0; index < n; index++)
        {
            Console.Write("Enter element {0}: ", index);
            arr[index] = Console.ReadLine();
        }

        // applying the QuickSort method on the array, 
        QuickSort(arr, 0, arr.Length - 1);

        // and printing the sorted numbers
        Console.WriteLine("\nSorted numbers: ");
        foreach (string str in arr)
        {
            Console.Write("{0} ", str);
        }
        Console.WriteLine();
    }
}

