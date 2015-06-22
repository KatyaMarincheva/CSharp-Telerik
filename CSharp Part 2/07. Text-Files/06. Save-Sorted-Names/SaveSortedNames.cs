// Problem 6. Save sorted names

/*    Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

Example:
input.txt 	output.txt
Ivan        George
Peter       Ivan
Maria       Maria
George 	    Peter
 */

using System;
using System.Collections.Generic;
using System.IO;


class SaveSortedNames
{
    static void Main()
    {
        List<string> names = new List<string>();
        using (StreamReader unsorted = new StreamReader(@"..\..\List.txt")) // this code "@"..\..\" retrieves files in same folder as the program .cs file
        {
            // recursion: keep reading while current != null (current read line)
            for (string current = unsorted.ReadLine(); current != null; current = unsorted.ReadLine())
            {
                names.Add(current);
            }

            names.Sort(); // sorting the names list

            using (StreamWriter sorted = new StreamWriter(@"..\..\SortedList.txt"))
            {
                foreach (string name in names)
                {
                    sorted.WriteLine(name); // writing the names from the sorted list to the SortedList.txt file
                }
            }
        }
        // print output file to the console
        string fileContents = File.ReadAllText(@"..\..\SortedList.txt");
        Console.WriteLine(fileContents);
    }
}


