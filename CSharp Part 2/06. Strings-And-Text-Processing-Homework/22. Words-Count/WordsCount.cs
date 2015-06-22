// Problem 22. Words count

// Write a program that reads a string from the console and lists all different 
// words in the string along with information how many times each word is found.

using System;
using System.Text.RegularExpressions;

class WordsCount
{
    public static void Main()
    {
        // regex pattern
        string pattern = "[^\\w]";
        //get all spaces and other signs, like: '.' '?' '!'

        // input
        string input = @"This is a nice day. 
What about this? 
This tastes good. 
I saw a dog!";

        // array to store the words
        string[] words = null;
        int i = 0;
        int count = 0;

        // print input
        Console.WriteLine(input);

        // fill the words array
        words = Regex.Split(input, pattern, RegexOptions.IgnoreCase);

        // count the words in the array, subtract count of empty strings
        for (i = words.GetLowerBound(0); i <= words.GetUpperBound(0); i++)
        {
            if (words[i].ToString() == string.Empty)
            {
                count = count - 1;
            }
            count = count + 1;
        }

        // printing
        Console.WriteLine("\nCount of words:" + count.ToString());

        Console.ReadKey();
    }
}

