

// Problem 14. Word dictionary

/*    A dictionary is stored as a sequence of text lines containing words and their explanations.
    Write a program that enters a word and translates it by using the dictionary.

Sample dictionary:
input 	    output
.NET 	    platform for applications from Microsoft
CLR 	    managed execution environment for .NET
namespace 	hierarchical organization of classesusing System;
 */
using System;
using System.Collections.Generic;
public class WordDictionary
{
    static void Main()
    {
        // input
        Console.WriteLine(@"Please enter below one of the following terms, 
so that you can retrieve from the dictionary 
the resppective definition: 
string
string data type
string metods:");
        Console.WriteLine();
        string input = Console.ReadLine();
        Console.WriteLine();

        // calling the term definitions from the dictionary
        CallDefinition(input);
        Console.WriteLine();
    }

    public static void CallDefinition(string input)
    {
        string definition = Knowledgebase[input];
        Console.WriteLine(definition);
    }

    // dictionary with terms-keys, and definitions-values
    public static readonly Dictionary<string, string> Knowledgebase = new Dictionary<string, string> 
    {
    { "string", @"Strings are sequences of characters 
- they are declared by the keyword string in C#. 
Strings can be initialized by string literals and 
use Unicode to support multiple languages and alphabets" },

    { "string data type", @"System.String is а reference data type. 
String objects are also implicitly manipulated as arrays of characters (char[]). 
String objects have fixed length (String.Length). 
The elements of the string char array
can be accessed directly by index 
(the index is in the range [0..Length-1])" },

    { "string methods", @"Most important string processing methods are:
Length, Compare(str1, str2), IndexOf(str), LastIndexOf(str), 
Substring(startIndex, length), Replace(oldStr, newStr), 
Remove(startIndex, length), ToLower(), ToUpper(), Trim()" },
    };
}

