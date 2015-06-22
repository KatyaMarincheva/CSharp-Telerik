// Problem 4. Sub-string in text

/* Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

Example:

The target sub-string is in

The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The result is: 9
 */

using System;
using System.Text.RegularExpressions;

class SubstringInText
{
    static void Main()
    {
        // input target substring
        Console.Write("Enter a target substring: ");
        string target = Console.ReadLine();

        // input text
        Console.WriteLine("Enter a text where we are going to be looking for our target substring:");
        string text = Console.ReadLine();

        // regex
        int number = Regex.Matches(text, target, RegexOptions.IgnoreCase).Count;

        // print
        Console.WriteLine("The substring \"{0}\" is found {1} times in the above text.", target, number);
    }
}

