using System;
using System.Collections.Generic;
using System.Linq;

class SubSetSum
{
    static int[] numbers;
    static int s;
    static bool solution = false;

    private static void PrintSubset(List<int> subset)
    {
        Console.Write("Sum = {0} ->", s);
        // print subset elements 0 to (subset.Count - 1)
        for (int i = 0; i < subset.Count; i++)
        {
            Console.Write("{0,3}", subset[i]);
        }
        Console.WriteLine();
    }

    private static int CalculateSum(List<int> subset)
    {
        int sum = 0;
        // after a subset is created, calculate the sum of its elements
        for (int i = 0; i < subset.Count; i++)
            sum += subset[i]; // add to the sum one by one all subset elements
        return sum; // return the sum as result
    }

    // when calling the method, we set the start index
    // this is why there is no value for index in the method itself
    static void MakeSubset(int index, List<int> subset)
    {
        int sum = CalculateSum(subset); // if any subset has already been created - calculate its sum
        if (sum == s) // if subset = s print subset elements
        {
            PrintSubset(subset);
            solution = true; // set solution to true, and we will not be printing that there is no solution
        }

        if (subset.Count == numbers.Length) // if susbset size = input array size
            return; // there is nothing more to be done, return

        for (int i = index; i < numbers.Length; i++)
        {
            subset.Add(numbers[i]); // add I-th element to the susbset list
            //Console.WriteLine(string.Join(" ", subset)); // uncomment this if you want to see what subsets are created
            MakeSubset(i + 1, subset); // call MakeSubset recursively, every time starting from the previous index + 1
            subset.RemoveAt(subset.Count - 1); // remove last element
        }
    }

    static void Main()
    {
        // input array
        Console.WriteLine("Please enter a sequence of numbers, separated by space or comma: ");
        char[] delimiter = new char[] { ',', ' ' };
        numbers = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        // input S
        Console.Write("Enter subset sum to check for: ");
        s = int.Parse(Console.ReadLine());

        // logic: make subsets, calculate their sums
        List<int> subset = new List<int>();
        MakeSubset(0, subset);

        // if no sum matches S
        if (!solution)
            Console.WriteLine("No subset with sum of {0}.", s);
    }
}