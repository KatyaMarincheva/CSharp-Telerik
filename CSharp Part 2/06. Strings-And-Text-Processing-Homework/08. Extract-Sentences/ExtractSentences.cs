// Problem 8. Extract sentences

/* Write a program that extracts from a given text all sentences containing given word.

Example:

The word is: in

The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

Consider that the sentences are separated by . and the words – by non-letter symbols.
 */

using System;
using System.Text.RegularExpressions;

class ExtractSentences
{
    static void Main()
    {
        // input text
        Console.WriteLine("Enter a text:");
        string text = Console.ReadLine();

        // input word to search for
        Console.Write("Enter the word that we are going to be looking for in the text: ");
        string word = Console.ReadLine();
        string[] sentences = text.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("\nSentences containing word \"{0}\":\n", word);

        // checking for the word in verey sentence of the sentences array
        for (int i = 0; i < sentences.Length; i++)
        {
            if (IsWordInSentence(sentences, i, word))
            {
                Console.WriteLine(sentences[i].Trim() + ".");
            }
        }
        Console.WriteLine();
    }

    // reterns matching sentences - sentences in which the count of the word is != 0
    private static bool IsWordInSentence(string[] sentences, int index, string word)
    {
        return Regex.Matches(sentences[index], string.Format(@"\b{0}\b", word), RegexOptions.IgnoreCase).Count != 0;
    }
}

