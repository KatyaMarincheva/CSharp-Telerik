// Problem 9. Delete odd lines

/*  Write a program that deletes from given text file all odd lines.
    The result should be in the same file.
 */

using System;
using System.Collections.Generic;
using System.IO;

class DeleteOddLines
{
    static void Main()
    {
        // print input file to the console
        Console.WriteLine("\nInput file:");
        string inputContents = File.ReadAllText(@"..\..\TextFile.txt");
        Console.WriteLine(inputContents);

        List<string> evenLines = new List<string>();
        using (StreamReader reader = new StreamReader(@"..\..\TextFile.txt")) // this code "@"..\..\" retrieves files in same folder as the program .cs file
        {
            // add every even line to a pre-defined evenLines list
            int lineNum = 1;
            string line = reader.ReadLine();
            while (line != null)
            {
                if (lineNum % 2 == 0)
                {
                    evenLines.Add(line);
                }
                lineNum++;
                line = reader.ReadLine();
            }
        }

        // re-write input file, using only the even lines
        using (StreamWriter output = new StreamWriter(@"..\..\TextFile.txt"))
        {
            for (int i = 0; i < evenLines.Count; i++)
            {
                output.WriteLine(evenLines[i]);
            }
        }
        Console.WriteLine("\nOdd lines removed!");

        // print output file to the console
        Console.WriteLine("\nOutput file:");
        string outputContents = File.ReadAllText(@"..\..\TextFile.txt");
        Console.WriteLine(outputContents);
    }
}

