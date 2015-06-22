using System;
using System.Collections.Generic;
using System.Text;
class Program
{
    static string FormatText(string command, string input)
    {
        char[] charr;
        string result = "";
        switch (command)
        {
            case "":
                return input;
            case "<upper>":
                result = input.ToUpper();
                break;
            case "<lower>":
                result = input.ToLower();
                break;
            case "<del>":
                return result;
            case "<rev>":
                charr = input.ToCharArray();
                Array.Reverse(charr);
                return new string(charr);
            case "<toggle>":
                charr = input.ToCharArray();
                int charrLen = charr.Length;
                for (int i = 0; i < charrLen; i++)
                {
                    char ch = charr[i];
                    if (char.IsLower(ch))
                        charr[i] = char.ToUpper(ch);
                    else if (char.IsUpper(ch))
                        charr[i] = char.ToLower(ch);
                }
                return new string(charr);
        }
        return result;
    }
    static string DoText(string command, string input)
    {
        while (input.Contains("<"))
        {
            int startCloseTag = input.IndexOf("</");
            int endCloseTag = input.IndexOf('>', startCloseTag);
            string closeTag = input.Substring(startCloseTag, endCloseTag - startCloseTag + 1);
            string openTag = closeTag.Remove(1, 1);
            int startOpenTag = input.LastIndexOf(openTag, startCloseTag);
            int endOpenTag = startOpenTag + openTag.Length;
            string text = input.Substring(endOpenTag, startCloseTag - endOpenTag);
            text = FormatText(openTag, text);
            input = input.Substring(0, startOpenTag) + text + input.Substring(endCloseTag + 1);
        }
        return input;
    }
    static void Main()
    {
        int numLines = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < numLines; i++)
        {
            sb.Append(Console.ReadLine() + "\n");
        }

        Console.Write(DoText("", sb.ToString()));
    }
}