// Problem 11. Prefix "test"

/*  Write a program that deletes from a text file all words that start with the prefix test.
    Words contain only the symbols 0…9, a…z, A…Z, _.
 */

using System;
using System.IO;
using System.Text.RegularExpressions;

class PrefixTest
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"..\..\test.txt")) // this code "@"..\..\" retrieves files in same folder as the program .cs file
        {
            using (StreamWriter output = new StreamWriter(@"..\..\result.txt"))
            {
                while (!reader.EndOfStream)
                {
                    // replace any word starting with test with an empty string
                    string line = Regex.Replace(reader.ReadLine(), @"\btest\S*", String.Empty).Trim();
                    output.Write(line);
                }
            }
        }
        Console.WriteLine("All words starting with \"test\" removed:");

        // print input and output file to the console
        Console.WriteLine("\nInput file:");
        string inputContents = File.ReadAllText(@"..\..\test.txt");
        Console.WriteLine(inputContents);

        Console.WriteLine("\nOutput file:");
        string outputContents = File.ReadAllText(@"..\..\result.txt");
        Console.WriteLine(outputContents);
        Console.WriteLine();
    }
}

