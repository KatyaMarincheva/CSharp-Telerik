// Problem 4. Compare text files

/*  Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
    Assume the files have equal number of lines.
 */

﻿using System;
using System.IO;
using System.Text;

class CompareTextFiles
{
    static void Main()
    {
        StreamReader reader1 = null;
        StreamReader reader2 = null;
        try
        {
            // find the two test files on any PC, as long as they are in the same folder with CompareTextFiles.cs
            reader1 = new StreamReader(@"..\..\test1.txt"); // this code "@"..\..\" retrieves files in same folder as the program .cs file
            reader2 = new StreamReader(@"..\..\test2.txt");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Cannot open test file(s)");
            return;
        }
        int equalLines = 0;
        int differentLines = 0;
        using (reader1)
        using (reader2)
        {
            // algorithm: reading one line of test1.txt, one of test2.txt; if equal equalLines++; else differentLines++;
            string s1 = reader1.ReadLine();
            string s2 = reader2.ReadLine();
            while (s1 != null)
            {
                if (s1 == s2)
                    equalLines++;
                else
                    differentLines++;
                s1 = reader1.ReadLine();
                s2 = reader2.ReadLine();
            }
        }
        Console.WriteLine("Number of identical lines: {0}", equalLines);
        Console.WriteLine("Number of different lines: {0}", differentLines);
    }
}

