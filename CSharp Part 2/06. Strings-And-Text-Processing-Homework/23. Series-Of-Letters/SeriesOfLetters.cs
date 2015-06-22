// Problem 23. Series of letters

/* Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

Example:
input 	                    output
aaaaabbbbbcdddeeeedssaa 	abcdedsa
 */

using System;
using System.Text.RegularExpressions;

class SeriesOfLetters
{
    static void Main()
    {
        //  The regex will match any character (.) and \\1+ will match whatever was captured in the first group.
        var regex = new Regex("(.)\\1+");
        var str = Console.ReadLine(); // or uncomment this string: "SSSSSomething likeeeee tttthhiiissss!!!!!";

        // printing
        Console.WriteLine(regex.Replace(str, "$1")); 
    }
}

