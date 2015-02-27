// Problem 2. Concatenate text files

// Write a program that concatenates two text files into another text file.

﻿using System;
using System.IO;
using System.Text;

class ConcatenateTextFiles
{

    static void MakeTestFile(int fileNumber)
    {
        // creating new StreamWriter instance
        StreamWriter writer = null;

        // trying to create new txt file
        try
        {
            writer = new StreamWriter(fileNumber + ".txt");
        }
        catch (IOException ex)
        {
            Console.WriteLine("Cannot create test file #{0}", fileNumber);
            throw (ex);
        }

        // writing 10 lines of text on the new txt file
        using (writer)
            for (int i = 0; i < 10; i++)
            {
                writer.WriteLine("File {0} line {1}", fileNumber, i + 1);
            }
    }

    static void Main(string[] args)
    {
        // trying to create 2 txt files
        try
        {
            MakeTestFile(1);
            MakeTestFile(2);
        }
        catch (IOException)
        {
            Console.WriteLine("Cannot create test files.");
            return;
        }

        // restarting StreamReader and StreamWriter
        StreamReader reader = null;
        StreamWriter writer = null;

            // try to open 1.txt
        try
        {
            reader = new StreamReader("1.txt");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Cannot open test file #1");
            return;
        }
            // try to create result.txt
        try
        {
            writer = new StreamWriter(@"..\..\result.txt");
        }
        catch (IOException)
        {
            Console.WriteLine("Cannot create result file");
            return;
        }

        // algorithm: read onne line from 1.txt - write it to result.txt
        // until all lines from 1.txt have been read (and re-qritten to result.txt)
        string s = null;
        using (writer)
        {
            using (reader)
            {
                s = reader.ReadLine();
                while (s != null)
                {
                    try
                    {
                        writer.WriteLine(s);
                    }
                    catch (IOException)
                    {
                        Console.WriteLine("Cannot write data to output file");
                    }
                    try
                    {
                        s = reader.ReadLine();
                    }
                    catch (IOException)
                    {
                        Console.WriteLine("Cannot read data from input file");
                    }
                }
            }

            try
            {
                reader = new StreamReader("2.txt");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Cannot open test file #2");
            }

            // repeating the above algoritm with 2.txt
            using (reader)
            {
                s = reader.ReadLine();
                while (s != null)
                {
                    try
                    {
                        writer.WriteLine(s);
                    }
                    catch (IOException)
                    {
                        Console.WriteLine("Cannot write data to output file");
                    }
                    try
                    {
                        s = reader.ReadLine();
                    }
                    catch (IOException)
                    {
                        Console.WriteLine("Cannot read data from input file");
                    }
                }
            }
        }

        // announce task completion
        // after you run the program, the 3 files: 1.txt, 2.txt, and result.txt, can be found in Text-Files\02. Concatenate-Text-Files\bin\Debug folder
        Console.WriteLine("Task comlete. Created file result.txt:\n");

        string fileContents = File.ReadAllText(@"..\..\result.txt");
        Console.WriteLine(fileContents);
    }

}

