// Problem 13.* Merge sort

// Write a program that sorts an array of integers using the Merge sort algorithm.

using System;
using System.Collections.Generic;

class MergeSortAlgorithm
{
    static List<int> MergeSort(List<int> intList)
    {
        // if this is a one element list
        if (intList.Count <= 1)
        {
            return intList;
        }

        // space for storing left and right groups of numbers
        List<int> left = new List<int>();
        List<int> right = new List<int>();

        // setting the initial list's middle point
        int middle = intList.Count / 2;

        // storing left group numbers into the left list
        for (int i = 0; i < middle; i++)
        {
            left.Add(intList[i]);
        }

        // storing right group numbers into the right list
        for (int i = middle; i < intList.Count; i++)
        {
            right.Add(intList[i]);
        }

        // repeating the above algorithm on both the left and the right lists ....
        left = MergeSort(left);
        right = MergeSort(right);

        // applying the Merge method on the result from the above
        return Merge(left, right);
    }

    static List<int> Merge(List<int> left, List<int> right)
    {
        // new, result list, for merging elements from the left and right lists
        List<int> result = new List<int>();

        // while we still have elements in either the left or the right list
        while (left.Count > 0 || right.Count > 0)
        {
            // if the count of both lists is above 0
            if (left.Count > 0 && right.Count > 0)
            {
                // we compare the values at 0 position in both (left and right) lists
                if (left[0] < right[0])
                {
                    // and if the left list value is lower, it gets 
                    // added to the result list and removed from the left list
                    AddAndRemove(left, result);
                }
                else
                {
                    // same if right value is lower
                    AddAndRemove(right, result);
                }
            }
            else if (left.Count > 0)
            {
                // removing last number from left list and adding it to the result list
                AddAndRemove(left, result);
            }
            else
            {
                // removing last number from right list and adding it to the result list
                AddAndRemove(right, result);
            }
        }
        return result; // the result from everything above will be the result list
    }

    // when this method is applied to two lists
    // it removes whaever is at 0 position of the first list
    // and adds it to the second list, here it comes at last position
    private static void AddAndRemove(List<int> removeFrom, List<int> addTo)
    {
        addTo.Add(removeFrom[0]);
        removeFrom.RemoveAt(0);
    }
    static void Main()
    {
        // input
        // value for N?
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        // initializing array of N numbers
        int[] arr = new int[n];
        for (int index = 0; index < n; index++)
        {
            Console.Write("Enter element {0}: ", index);
            arr[index] = int.Parse(Console.ReadLine());
        }

        // storing the array numbers into the intList
        // (unlike arrays, lists do not have a constant count - 
        // so we can remove numbers from the intList)
        List<int> intList = new List<int>(arr);

        // the code below applies the MergeSort method on the intList
        // and prints each number from the result list 
        // which as shown above is the output of the MergeSort method
        foreach (int i in MergeSort(intList))
        {
            Console.WriteLine(i);
        }
    }
}

