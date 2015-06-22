// Problem 7. Replace sub-string

/*  Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
    Ensure it will work with large files (e.g. 100 MB).
 */

using System;
using System.IO;

class ReplaceSubstring
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"..\..\text.txt")) // this code "@"..\..\" retrieves files in same folder as the program .cs file
        {
            using (StreamWriter output = new StreamWriter(@"..\..\result.txt"))
            {
                // algorithm: read a line from input file, 
                // make from the read line a newLine, with the start/finish words replaced 
                // write the newLine to the output file
                for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                {
                    string newLine = line.Replace("start", "finish");
                    output.WriteLine(newLine);
                }
            }
        }
        Console.WriteLine("Replacing done!");

        // print input and output file to the console
        Console.WriteLine("\nInput file:");
        string inputContents = File.ReadAllText(@"..\..\text.txt");
        Console.WriteLine(inputContents);

        Console.WriteLine("\nOutput file:");
        string outputContents = File.ReadAllText(@"..\..\result.txt");
        Console.WriteLine(outputContents);
    }
}

