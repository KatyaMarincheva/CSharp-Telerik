// Problem 3. Line numbers

/*  Write a program that reads a text file and inserts line numbers in front of each of its lines.
    The result should be written to another text file.
 */

using System;
using System.IO;
using System.Text;

class LineNumbers
{
    static void Main(string[] args)
    {
        StreamReader reader = null;
        StreamWriter writer = null;

        // open input (current) file
        try
        {
            // this code "@"..\..\" retrieves files in same folder as the program .cs file
            reader = new StreamReader(@"..\..\LineNumbers.cs", Encoding.GetEncoding("windows-1251"));
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }

        // create output file
        try
        {
            writer = new StreamWriter(@"..\..\LineNumbers.txt");
        }
        catch (IOException)
        {
            Console.WriteLine("Unable to create output file.");
        }


        string s;
        int lineNumber = 1;
        using (reader)
        using (writer)
        {
            do // algorithm: read one line from input file, write line number + that line to output file
            {
                s = reader.ReadLine();
                writer.WriteLine("{0} {1}", lineNumber, s);
                lineNumber++;
            } while (s != null);
        }
        Console.WriteLine("Task complete:\n");

        // print output file to the console
        string fileContents = File.ReadAllText(@"..\..\LineNumbers.txt");
        Console.WriteLine(fileContents);
    }
}

