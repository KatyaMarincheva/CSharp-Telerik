// Problem 8. Square Root - Create a console application that calculates and prints the square root of the number 12345.

using System;

class SquareRoot
{
    static void Main()
    {
        Console.Title = "Square Root";

        double squareRoot = Math.Sqrt(12345);
        Console.WriteLine("The square root of 12345 is {0}.", squareRoot);

        Console.CursorVisible = false;
        Console.ReadLine();
    }
}

