//Problem 17.* Subset K with sum S

/* Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
    Find in the array a subset of K elements that have sum S or indicate about its absence.
 */

using System;
using System.Collections.Generic;
using System.Linq;

class SubSetSum
{
    static int[] array;
    static int s;
    static int k;
    static bool solution = false;
    static void Main()
    {
        // input array
        Console.WriteLine("Please enter a sequence of numbers, separated by space or comma: ");
        char[] delimiter = new char[] { ',', ' ' };
        array = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        // input for S and K
        Console.Write("Enter number of elements in subset: ");
        k = int.Parse(Console.ReadLine());
        Console.Write("Enter subset sum to check for: ");
        s = int.Parse(Console.ReadLine());

        // logic: make subsets, calculate their sums
        List<int> subset = new List<int>();
        MakeSubset(0, subset);

        // if no sum of K elements matches S
        if (!solution)
            Console.WriteLine("No subset with sum of {0}.", s);
    }

    // when calling the method, we set the start index
    // this is why there is no value for index in the method itself
    static void MakeSubset(int index, List<int> subset)
    {
        if (subset.Count == k) // if subset list is exactly K element long
        {
            int sum = 0;
            for (int i = 0; i < subset.Count; i++)
                sum = sum + subset[i]; // calculate sum of K elements
            if (sum == s) // if sum of K elements = S
            {
                Console.Write("Sum = {0} ->", s);
                // print subset elements 0 to (subset.Count - 1)
                for (int i = 0; i < subset.Count; i++)
                    Console.Write("{0,3}", subset[i]);
                Console.WriteLine();
                solution = true;
            }
            return;
        }

        // subset is exactly K elements long, so no need to check for i > N-K; 
        // and  (- k + subset.Count + 1) additionally limites the number of created and checked subsets
        for (int i = index; i < array.Length - k + subset.Count + 1; i++) 
        {
            subset.Add(array[i]);
            // Console.WriteLine(string.Join(" ", subset)); // you can uncomment this to see what subsets are created and checked
            MakeSubset(i + 1, subset);
            subset.RemoveAt(subset.Count - 1);
        }
    }
}
