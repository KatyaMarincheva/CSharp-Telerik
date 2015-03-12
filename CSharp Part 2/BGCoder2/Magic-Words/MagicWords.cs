using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

class MagicWords
{
    static void Main()
    {
        int numberOfWords = int.Parse(Console.ReadLine());
        string[] words = new string[numberOfWords];

        for (int i = 0; i < numberOfWords; i++)
        {
            words[i] = Console.ReadLine();
        }

        words = Reorder(words, numberOfWords);
        Console.WriteLine(Print(words));
    }

    private static string[] Reorder(string[] words, int numberOfWords)
    {
        List<string> list = words.OfType<string>().ToList();

        for (int i = 0; i < list.Count; i++)
        {
            string currentWord = list[i];
            int newIndex = (currentWord.Length % (numberOfWords + 1));

            string buffer = currentWord;
            list[i] = null;
            list.Insert(newIndex, buffer);
            list.Remove(null);
        }

        words = list.ToArray();

        return words;
    }

    private static string Print(string[] words)
    {
        StringBuilder result = new StringBuilder();
        int index = 0;

        var sorted = words.OrderBy(n => n.Length);
        var longest = sorted.LastOrDefault();

        while (index < longest.Length)
        {
            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];

                if (index < currentWord.Length)
                {
                    result.Append(currentWord[index]);
                }
            }

            index++;
        }

        return result.ToString();
    }
}

