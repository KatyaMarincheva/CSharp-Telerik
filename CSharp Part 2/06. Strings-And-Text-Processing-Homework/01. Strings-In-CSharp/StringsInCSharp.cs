// Problem 1. Strings in C#.

/*  Describe the strings in C#.
    What is typical for the string data type?
    Describe the most important methods of the String class.
 */

using System;
using System.Collections.Generic;

class StringsInCSharp
{
    static void Main()
    {
        // calling the Knowledgebase dictionary from Problem 14, and printing the answers to all Problem 1 questions
        foreach (KeyValuePair<string, string> kvp in WordDictionary.Knowledgebase)
        {
            Console.WriteLine("Question: {0} \nAnswer: {1}\n",
                kvp.Key, kvp.Value);
        }
    }
}

