// Problem 21.* Combinations of set

/* Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].

Example:
N 	K 	result
5 	2 	{1, 2}
{1, 3}
{1, 4}
{1, 5}
{2, 3}
{2, 4}
{2, 5}
{3, 4}
{3, 5}
{4, 5}
 */

using System;
class CombinationsOfSet
{
    static int[] result;
    static int k;
    static int n;
    static void Main()
    {
        // input
        Console.Write("Enter number of elements for combinations: ");
        n = int.Parse(Console.ReadLine());
        Console.Write("Enter lenght of combination: ");
        k = int.Parse(Console.ReadLine());
        result = new int[k];

        // aplying the Combinations method
        Combinations(0, 1);
    }
    static void Combinations(int index, int startValue)
    {
        // print the result when we have exactly K elements
        if (index == k)
        {
            for (int i = 0; i < k; i++)
                Console.Write("{0,3}", result[i]);
            Console.WriteLine();
            return;
        }

        // contiuously change elements' indexes in result array
        for (int i = startValue; i <= n; i++)
        {
            result[index] = i;
            Combinations(index + 1, i + 1);
        }
    }
}
