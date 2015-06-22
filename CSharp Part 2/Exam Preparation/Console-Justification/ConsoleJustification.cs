using System;
using System.Collections.Generic;
using System.Text;

class ConsoleJustification
{
    static int count = 0;
    static void Main()
    {
        // input
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
        //Console.WriteLine(string.Join(" ", words));

        // distribute words into lines
        List<string> result = new List<string>();
        while (words.Count != 0)
        {
        var line = WordsPerLine(W, words);
        //Console.WriteLine(line);
        words.RemoveRange(0, count);
        result.Add(line.ToString());
        line = "";
        count = 0;
        }

        // add spaces
        AddSpacesBetweenWords(W, result);
        foreach (var s in result)
        {
            Console.WriteLine(s);
        }

        //for (int i = 0; i < parag.Length; i++)
        //{
        //    string x = string.Join(" ", justified);
        //    int currentLength = x.Length;
        //    if (currentLength < W)
        //    {
        //        justified.Insert(i + 1, " ");
        //    }
        //}
    }

    // define words per line
    private static string WordsPerLine(int W, List<string> words)
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
        return line.ToString().Trim();
    }

    private static void AddSpacesBetweenWords(int width, List<string> result)
    {
        for (int i = 0; i < result.Count; i++)
        {
            int space = 1, index = 0;
            while (result[i].Length < width && index != -1)
            {
                index = result[i].IndexOf(new string(' ', space), StringComparison.Ordinal);
                while (index != -1 && result[i].Length < width && index != result[i].Length - 1)
                {
                    result[i] = result[i].Insert(index, " ");
                    index = result[i].IndexOf(new string(' ', space), index + space + 1, StringComparison.Ordinal);
                }
                space++;
                index = result[i].IndexOf(new string(' ', space), StringComparison.Ordinal);
            }
        }
    }
}

