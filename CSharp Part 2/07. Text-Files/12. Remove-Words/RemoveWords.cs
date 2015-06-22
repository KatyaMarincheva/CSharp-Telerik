// Problem 12. Remove words

/*  Write a program that removes from a text file all words listed in given another text file.
    Handle all possible exceptions in your methods.
 */

using System;
using System.IO;
using System.Collections.Generic;

class RemoveWords
{
    // algorithm: we read a line from the text file, 
    // we split it into words
    // and add the words which do not match dictionary words into a new, result line
    static string CleanLine(string s, HashSet<string> dictionary)
    {
        string result = "";
        string[] words = s.Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < words.Length; i++)
        {
            if (!dictionary.Contains(words[i].ToLower()))
            {
                if (result != "")
                    result = result + " ";
                result = result + words[i];
            }
        }
        return result;
    }

    // read dictionary file, split it into words, store the words in HashSet<string> dictionary
    static HashSet<string> ReadDictionary()
    {
        string[] words;
        HashSet<string> dictionary = new HashSet<string>();
        using (StreamReader reader = new StreamReader(@"..\..\dictionary.txt"))
        {
            while (!reader.EndOfStream)
            {
                words = reader.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string s in words)
                {
                    dictionary.Add(s.ToLower());
                }
            }
        }
        return dictionary;
    }


    static void Main()
    {
        HashSet<string> dictionary;
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
        try
        {
            using (StreamReader reader = new StreamReader(@"..\..\text.txt"))
            using (StreamWriter writer = new StreamWriter(@"..\..\result.txt"))
            {
                while (!reader.EndOfStream)
                    writer.WriteLine(CleanLine(reader.ReadLine(), dictionary));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading dictionary file. Reason:" + ex.Message);
            Console.WriteLine(ex.StackTrace);
            return;
        }
        Console.WriteLine("Task complete.");

        // print input, dictionary, and output files to the console
        Console.WriteLine("\nInput file:");
        string inputContents = File.ReadAllText(@"..\..\text.txt");
        Console.WriteLine(inputContents);

        Console.WriteLine("\nDictionary file:");
        string dictionaryContents = File.ReadAllText(@"..\..\dictionary.txt");
        Console.WriteLine(dictionaryContents);

        Console.WriteLine("\nOutput file:");
        string outputContents = File.ReadAllText(@"..\..\result.txt");
        Console.WriteLine(outputContents);
    }
}

