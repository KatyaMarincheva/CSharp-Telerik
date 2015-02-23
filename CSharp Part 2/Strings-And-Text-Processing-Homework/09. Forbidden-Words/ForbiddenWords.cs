// Problem 9. Forbidden words

/*  We are given a string containing a list of forbidden words and a text containing some of these words.
    Write a program that replaces the forbidden words with asterisks.

Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

Forbidden words: PHP, CLR, Microsoft

The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
 */

using System;
using System.Text.RegularExpressions;


class ForbiddenWords
{
    static void Main()
    {
        // input text
        Console.WriteLine("Please, enter a text here:");
        string text = Console.ReadLine();
        char[] delimiter = new char[] { ' ' };

        // input forbidden words array
        Console.WriteLine("Please, choose which of the words in the above text will be forbidden, \nand enter them all on one line, separated by space:");
        string[] forbiddenWords = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

        // regex
        string regex = string.Format(@"\b({0})\b", string.Join("|", forbiddenWords));

        // replace and print
        Console.WriteLine("Output: \n\n{0}\n", Regex.Replace(text, regex, word => new string('*', word.Length)));
    }
}

