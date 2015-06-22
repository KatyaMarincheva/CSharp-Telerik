// Problem 20. Palindromes

// Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

using System;
using System.Text.RegularExpressions;
using System.Linq;

    class Palindromes
    {
        static void Main()
        {
            // input
            var s = @"<<< ABBA, lamal, exe, Console >>>";

            // searching for regex matches where string == string reversed
            var result = Regex.Matches(s, @"\w+").Cast<Match>() 
            .Select(m => m.Value.ToLower()) 
            .Where(w => String.Join("", w.Reverse()) == w) 
            .GroupBy(w => w) 
            .Select(g => new { Word = g.Key, Count = g.Count() }) // preparing for print
            .ToList(); 

            result.ForEach(Console.WriteLine); // printing the result
            Console.WriteLine();
        }
    }

