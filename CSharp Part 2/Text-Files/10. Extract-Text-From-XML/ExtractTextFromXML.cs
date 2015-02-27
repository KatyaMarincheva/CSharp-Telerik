// Problem 10. Extract text from XML

/* Write a program that extracts from given XML file all the text without the tags.

Example:

<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games
 * </interest><interest>C#</interest><interest>Java</interest></interests></student>
 */

using System;
using System.IO;

class ExtractTextFromXML
{
    private static void Main()
    {
        using (StreamReader reader = new StreamReader(@"..\..\text.xml")) // this code "@"..\..\" retrieves files in same folder as the program .cs file
        {
            string line = reader.ReadLine();
            string extract = string.Empty;
            while (line != null)
            {
                // add to extract string everything between the tags
                for (int i = 1; i < line.Length; i++)
                {
                    if (line[i - 1] == '>')
                    {
                        while (line[i] != '<')
                        {
                            extract += line[i];
                            i++;
                        }
                    }
                }
                line = reader.ReadLine();
            }

            // print result
            Console.WriteLine(extract);
        }
    }
}

