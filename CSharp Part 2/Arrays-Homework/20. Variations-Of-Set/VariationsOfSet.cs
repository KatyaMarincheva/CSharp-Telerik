// Problem 20.* Variations of set

/* Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].

Example:
N 	K 	result
3 	2 	{1, 1}
        {1, 2}
        {1, 3}
        {2, 1}
        {2, 2}
        {2, 3}
        {3, 1}
        {3, 2}
        {3, 3}
 */

using System;
class Permutations
{
    static int[] result;
    static int k;
    static int n;
    static void Main()
    {
        // input
        Console.Write("Enter number of elements for variations: ");
        n = int.Parse(Console.ReadLine());
        Console.Write("Enter lenght of variation: ");
        k = int.Parse(Console.ReadLine());
        result = new int[k];

        // applying the variations method
        Variations(0);
    }

    static void Variations(int index)
    {
        // print the result if we have exactly K elements
        if (index == k)
        {
            for (int i = 0; i < k; i++)
                Console.Write("{0,3}", result[i]);
            Console.WriteLine();
            return;
        }

        // set index of result elements at new positions
        for (int i = 0; i < n; i++)
        {
            result[index] = i + 1;
            Variations(index + 1);
        }
    }
}

