// Requirements
/*
 * Input:
 * On the first line of the input there will be the number N – the total number of lines in Joro’s initial code.
 * On the next line of the input there will be a string S – the indentation string, which can consist of any symbols.
 * Each of the next N lines will contain a line of Joro’s code. 
 * •	0 < N < 1000
 * •	0 < S.Length < 100
 * •	S will not have leading or trailing whitespaces (S.Trim() will be equal to S)
 * •	There could be empty lines in the input
 * •	There could be sequences of whitespaces in the input
 * 
 * To do:
 * read input
 * if you come across a bracket:
 * add Environment.NewLine, add identation (S * x), add bracket, add Environment.NewLine  
 * 
 * 
 * Output:
 * You must print all lines of the formatted code.
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Brackets
{
    static void Main()
    {
        // input
        int N = int.Parse(Console.ReadLine());

        string S = Console.ReadLine();

        string[] input = new string[N];

        for (int i = 0; i < N; i++)
        {
            input[i] = Console.ReadLine();
        }

        char[] delimiter = new char[] { ' ' };
        List<string> lines = new List<string>();
        foreach (string str in input)
        {
            if (!string.IsNullOrEmpty(str))
            {
                string[] paragraph = str.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
                lines.Add(string.Join(" ", paragraph));
            }

        }

        List<string> results = new List<string>();
        // split after bracket
        var result = new StringBuilder();
        int countO = 0;
        int countC = 1;
        foreach (string s in lines)
        {
            for (int i = 0; i < s.Length; i++)
            {

                if (s[i] == '{' || s[i] == '}')
                {
                    result.Append(Environment.NewLine);

                    result.Append(s[i]);
                    result.Append(Environment.NewLine);

                }
                else
                {
                    result.Append(s[i]);
                }
            }
            results.Add(result.ToString());
            result.Clear();
        }

        List<string> finals = new List<string>();

        foreach (var item in results)
        {
            string[] par = item.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var s in par)
            {
                s.Trim();
                if (s == "{")
                {
                    finals.Add(string.Concat(Enumerable.Repeat(S, countO)) + s);
                    countO++;

                }
                else if (s == "}")
                {

                    countO--;
                    finals.Add(string.Concat(Enumerable.Repeat(S, countO)) + s);
                }

                else
                {
                    finals.Add(string.Concat(Enumerable.Repeat(S, countO)) + s);
                }

            }
        }
        foreach (string s in finals)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine();
    }
}

