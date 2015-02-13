//Problem 3. Compare char arrays

// Write a program that compares two char arrays lexicographically (letter by letter).

using System;
using System.Collections.Generic;
using System.Linq;

class CompareCharArrays
{
    static void Main()
    {
        // input
        Console.WriteLine("Please enter two words - each on a different line:");
        string first = Console.ReadLine();
        string second = Console.ReadLine();

        // if the arrays are of different length, we check the two arrays 
        // for the count of the elements in the shoerter array
        for (int i = 0; i < Math.Min(first.Length, second.Length); i++)
        {
            // this check up is implicitly by ASCII code
            if (first[i] < second[i])
            {
                Console.WriteLine("{0} < {1}", first, second);
                return;
            }

            if (first[i] > second[i])
            {
                Console.WriteLine("{0} > {1}", first, second);
                return;
            }
        }

        // if all characters that were compared are equal, we end up comparing the arrays by length
        if (first.Length == second.Length)
        {
            Console.WriteLine("The words are equal");
        }

        else
        {
            // lexigographically first comes the array with shorter length
            Console.WriteLine(first.Length < second.Length ? "{0} < {1}\n" : "{1} < {0}\n", first, second);
        }
    }
}

