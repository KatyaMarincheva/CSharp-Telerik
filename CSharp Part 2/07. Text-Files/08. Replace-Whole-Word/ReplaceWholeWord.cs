
// Problem 8. Replace whole word

//  Modify the solution of the previous problem to replace only whole words (not strings).

using System;
using System.IO;

class ReplaceWholeWord
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"..\..\text.txt")) // this code "@"..\..\" retrieves files in same folder as the program .cs file
        {
            using (StreamWriter output = new StreamWriter(@"..\..\result.txt"))
            {
                // keep reading lines from input file, until there are no more lines to read
                for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                {
                    for (int i = line.IndexOf("start"); i != -1; i = line.IndexOf("start", i + 1))
                    {
                        // algorithm: if you are at line start or line end, or there are no letter chars before or after the word "start"
                        if ((i - 1 < 0 || !Char.IsLetter(line[i - 1])) && (i + 5 >= line.Length) || !Char.IsLetter(line[i + 5]))
                        {
                            // insert "finish" and remove the 5 chars after it (corresponding to the word "start"
                            line = line.Insert(i, "finish").Remove(i + 6, 5);
                        }
                    }
                    // write line with replacement to output file
                    output.WriteLine(line);
                }
            }
        }
        Console.WriteLine("Replacing completed!");

        // print input and output file to the console
        Console.WriteLine("\nInput file:");
        string inputContents = File.ReadAllText(@"..\..\text.txt");
        Console.WriteLine(inputContents);

        Console.WriteLine("\nOutput file:");
        string outputContents = File.ReadAllText(@"..\..\result.txt");
        Console.WriteLine(outputContents);
    }
}

