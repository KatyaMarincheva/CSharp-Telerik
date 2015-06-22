using System;
using System.Collections.Generic;
using System.Text;
class Brackets
{
    static void Main()
    {
        int numLines = int.Parse(Console.ReadLine());
        string indentation = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < numLines; i++)
        {
            if (i > 0) sb.Append(Environment.NewLine);
            sb.Append(Console.ReadLine());
        }
        sb.Replace("{", Environment.NewLine + "{" + Environment.NewLine);
        sb.Replace("}", Environment.NewLine + "}" + Environment.NewLine);
        int sbLen = 0;
        do
        {
            sbLen = sb.Length;
            sb.Replace(Environment.NewLine + Environment.NewLine, Environment.NewLine);
            sb.Replace("  ", " ");
        } while (sbLen != sb.Length);
        string[] lines = sb.ToString().Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        string indent = "";
        for (int i = 0; i < lines.Length; i++)
        {
            lines[i] = lines[i].Trim();
            if (lines[i] == "") continue;
            if (lines[i] == "}")
                indent = indent.Remove(0, indentation.Length);
            Console.Write(indent);
            Console.WriteLine(lines[i]);
            if (lines[i] == "{")
                indent = indent + indentation;
        }
    }
}
