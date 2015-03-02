using System;
using System.Collections.Generic;
using System.Text;

class ConsoleJustification
{
    static int count = 0;
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int W = int.Parse(Console.ReadLine());

        string[] input = new string[N];

        for (int i = 0; i < N; i++)
        {
            input[i] = Console.ReadLine();
        }

        char[] delimiter = new char[] { ' ' };
        List<string> words = new List<string>();
        foreach (string str in input)
        {
            string[] paragraph = str.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in paragraph)
            {
                words.Add(s);
            }
        }
        Console.WriteLine(string.Join(" ", words));

        List<string> result = new List<string>();
        while (words.Count != 0)
        {
        var line = WordsPerLine(W, words);
        //Console.WriteLine(line);
        words.RemoveRange(0, count);
        result.Add(line.ToString());
        line.Clear();
        count = 0;
        }

        foreach (string s in result)
        {
            Console.WriteLine(s);
        }

        string[] parag = str.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
        List<string> justified = new List<string>(parag);
        foreach (string s in parag)
        {
            words.Add(s);
        }
    }

    // define words per line
    private static StringBuilder WordsPerLine(int W, List<string> words)
    {
        var line = new StringBuilder();

        for (int i = 0; i < words.Count; i++)
        {
            line.Append(words[i]);
            count++;
            if (line.Length > W)
            {
                line.Remove(line.Length - words[i].Length - 1, words[i].Length + 1);
                count--;
                break;
            }
            line.Append(" ");
        }
        return line;
    }
}

