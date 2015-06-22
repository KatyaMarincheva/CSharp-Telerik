//Problem 19.* Permutations of set

/* Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].

Example:
N 	result
3 	{1, 2, 3}
    {1, 3, 2}
    {2, 1, 3}
    {2, 3, 1}
    {3, 1, 2}
    {3, 2, 1}
 */

using System;
using System.Collections.Generic;
using System.Linq;

class PermutationsOfSet
{
    static int[] result;

    static void Main()
    {
        // input
        Console.Write("Enter number of elements for permutation: ");
        int n = int.Parse(Console.ReadLine());

        // declarations
        result = new int[n];

        // iinitial list based on which permutations will be calculated
        List<int> perm = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            perm.Add(i);
        }

        // applying the Permutations method
        Permutations(perm);
    }

    static void Permutations(List<int> perm)
    {
        // all permutation sequences trasferred from perm to result
        if (perm.Count == 0)
        {
            for (int i = 0; i < result.Length; i++)
                Console.Write("{0,3}", result[i]);
            Console.WriteLine();
            return;
        }
        for (int i = 0; i < perm.Count; i++)
        {
            // you can uncheck the below to visualize the process
            result[result.Length - perm.Count] = perm[i];
            //Console.WriteLine(string.Join(" ", result));
            perm.RemoveAt(i);
            //Console.WriteLine(string.Join(" ", perm));
            Permutations(perm);
            perm.Insert(i, result[result.Length - perm.Count - 1]);
            //Console.WriteLine(string.Join(" ", perm));
        }
    }
}