// Problem 13. Reverse sentence

/* Write a program that reverses the words in given sentence.

Example:
input 	output
C# is not C++, not PHP and not Delphi! 	Delphi not and PHP, not C++ not is C#!
 */

using System;

class ReverseSentence
{
    static void Main()
    {
        // input
        Console.WriteLine("Please, enter a sentence: ");
        string sentence = Console.ReadLine();

        ReverseWords(sentence);
    }

    private static void ReverseWords(string sentence)
    {
        char sign = sentence[sentence.Length - 1]; // identifying and temporarily removing the mark of terminal punctuation
        sentence = sentence.Remove(sentence.Length - 1, 1);
        string[] words = sentence.Split(' ');

        // reversing
        Array.Reverse(words);
        Console.WriteLine("\nReversed:");
        Console.WriteLine("{0}{1}\n", string.Join(" ", words), sign); // adding back the mark of terminal punctuation
    }
}

