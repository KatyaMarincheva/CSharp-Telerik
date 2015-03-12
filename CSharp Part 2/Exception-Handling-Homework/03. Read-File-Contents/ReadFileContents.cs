// Problem 3. Read file contents

/*  Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
    Find in MSDN how to use System.IO.File.ReadAllText(…).
    Be sure to catch all possible exceptions and print user-friendly error messages.
 */

using System;
using System.IO;

class ReadFileContents
{
    static void Main()
    {
        Console.WriteLine("Please, enter the full path to the file, \nalong with the file name, e.g.: \n C:\\Desktop\\New Text Document (2).txt");
        string pathAndName = Console.ReadLine();
        try
        {
            string fileContents = File.ReadAllText(pathAndName);
            Console.WriteLine(fileContents);
        }

        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Input directory name that does not exist.");
        }

        catch (FileNotFoundException)
        {
            Console.WriteLine("Could not find the specified file in the specifiled directory.");
            Console.WriteLine("No path input. Could not find the specified file in the current directory.");
        }

        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Access to the path {0} is denied.", pathAndName);
            Console.WriteLine("Or you haven't specified any file name in the specified directory.");
        }

        catch (IOException)
        {
            Console.WriteLine("File is currentlu in use by another process.");
        }

        catch (ArgumentException)
        {
            Console.WriteLine("Input is an empty string.");
        }
    }
}

