// Problem 21. Letters count

// Write a program that reads a string from the console and prints 
// all different letters in the string along with information how many times each letter is found.

using System;
using System.Collections.Generic;
using System.Linq;

class LettersCount
{
    static void Main()
    {
        // input
        Console.Write("Enter text with letters to count: ");
        string text = Console.ReadLine().ToLower();
        Console.WriteLine();

        // this dictionary will hold the pairs: letter (key) -> count (value)
        Dictionary<char, int> dict = new Dictionary<char, int>();

        // if we come across a letter in the text - we add the letter and is count to the dictionary
        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsLetter(text[i]))
            {
                if (!dict.ContainsKey(text[i])) // if the letter is not already added
                {
                    dict.Add(text[i], text.Count(x => x == text[i]));
                }
            }
        }

        // we want the dictionary letter-keys sorted lexicographically
        var list = dict.Keys.ToList();
        list.Sort();

        // printing
        foreach (var key in list)
        {
            Console.WriteLine("Letter: {0} -> count: {1}\n",
                key, dict[key]);
        }
    }
}

