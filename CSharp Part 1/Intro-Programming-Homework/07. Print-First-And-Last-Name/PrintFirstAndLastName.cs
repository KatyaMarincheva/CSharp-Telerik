// Problem 7. Print First and Last Name - Create console application that prints your first and last name, each at a separate line.

using System;

class PrintFirstAndLastName
{
    static void Main()
    {
        Console.Title = "Print First and Last Name";

        Console.WriteLine("\n     Name\n     Surname");

        Console.CursorVisible = false;
        Console.ReadLine();
    }
}

