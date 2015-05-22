// Problem 13. Count words

/*  Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
    The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
    Handle all possible exceptions in your methods.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class CountWords
{
    // adding a value to Dictionary<string, int> dictionary
    // 1. we assume that any word found in the line we read is a dictionary key
    // 2. if the theoretically key-word matches a key-word from Dictionary<string, int> dictionary
    // we increase its respective value: 
    // the value is initially 0, and dictionary[key]++; increases it with one
    // every time we match the same key-word into the lines we read 
    static void CountWordInLine(string line, Dictionary<string, int> dictionary)
    {
        string[] words = line.Split(new string[] { " ", ",", "." }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < words.Length; i++)
        {
            string key;
            if (char.IsLetter(words[i][words[i].Length - 1]))
                key = words[i];
            else
                key = words[i].Substring(0, words[i].Length - 2);
            if (dictionary.ContainsKey(key))
                dictionary[key]++;
        }
    }

    // reading the words.txt file, splitting it into words, storing the words into Dictionary<string, int> dictionary as keys
    // the values are all still 0 -> dictionary.Add(s, 0);
    static Dictionary<string, int> ReadDictionary()
    {
        string[] words;
        Dictionary<string, int> dictionary = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);
        using (StreamReader reader = new StreamReader(@"..\..\words.txt"))
        {
            while (!reader.EndOfStream)
            {
                words = reader.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string s in words)
                    if (char.IsLetter(s[s.Length - 1]))
                        dictionary.Add(s, 0);
                    else
                        dictionary.Add(s.Substring(0, s.Length - 2), 0);
            }
        }
        return dictionary;
    }

    static void Main()
    {
        // we try to read the dictionary file, and acknowledge with an exception an eventual failure
        Dictionary<string, int> dictionary;
        try
        {
            dictionary = ReadDictionary();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading dictionary file. Reason:" + ex.Message);
            Console.WriteLine(ex.StackTrace);
            return;
        }

        // we try to match the words from the test.txt file we read with the ones from the dictionary
        // and acknowledge with an exception an eventual failure
        try
        {
            using (StreamReader reader = new StreamReader(@"..\..\text.txt"))
            {
                while (!reader.EndOfStream)
                    CountWordInLine(reader.ReadLine(), dictionary);
                Console.WriteLine();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading dictionary file. Reason:" + ex.Message);
            Console.WriteLine(ex.StackTrace);
            return;
        }

        // now we try to write the counting results to a new file, result.txt
        // and acknowledge with an exception an eventual failure
        // OrderByDescending(key => key.Value) does the sorting
        try
        {
            using (StreamWriter writer = new StreamWriter(@"..\..\result.txt"))
            {
                foreach (KeyValuePair<string, int> item in dictionary.OrderByDescending(key => key.Value))
                {
                    writer.WriteLine("Word: {0}, Count: {1}", item.Key, item.Value);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading dictionary file. Reason:" + ex.Message);
            Console.WriteLine(ex.StackTrace);
            return;
        }
        Console.WriteLine("Task complete:");

        // print input, words, and output files to the console
        Console.WriteLine("\nInput file:");
        string inputContents = File.ReadAllText(@"..\..\text.txt");
        Console.WriteLine(inputContents);

        Console.WriteLine("\nWords file:");
        string dictionaryContents = File.ReadAllText(@"..\..\words.txt");
        Console.WriteLine(dictionaryContents);

        Console.WriteLine("\nOutput file:");
        string outputContents = File.ReadAllText(@"..\..\result.txt");
        Console.WriteLine(outputContents);
    }
}

