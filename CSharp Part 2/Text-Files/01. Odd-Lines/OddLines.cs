using System;
using System.IO;
using System.Text;

class OddLines
{
    static void Main(string[] args)
    {
        try
        {
            // input
            StreamReader reader = new StreamReader(@"..\..\OddLines.cs", Encoding.GetEncoding("windows-1251"));
            // this code "@"..\..\" retrieves files in same folder as the program .cs file

            string s;
            int lineNumber = 1;
            
            // algorithm: line number increases twice, the reader reads twice, console prints once
            using (reader)
            {
                do
                {
                    s = reader.ReadLine();
                    Console.WriteLine("Line {0}: {1}", lineNumber, s);
                    lineNumber++;
                    s = reader.ReadLine();
                    lineNumber++;
                } while (s != null);
            }
        }

            // in case no file is found
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
    }
}

