// Problem 8. Isosceles Triangle

/*Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:

   ©

  © ©

 ©   ©

© © © ©

Note: The © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console.

Note: Under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it. */

using System;
using System.Text; // necessary for the use of the Encoding Class
using System.Threading; // because I wanted to use the Thread.Sleep() method, and pause the program at times

class IsoscelesTriangleTwo
{
    // the WriteAt() method below has 3 arguments: what to right + 
    // the coordinates (width/ height) of the point at which exactly this method will be printing
    protected static void WriteAt(char copiright, int x, int y)
    {
        Console.SetWindowSize(27, 13); //sets console window size (width, height)
        Console.SetBufferSize(27, 13); // sets console buffer size (width, height)

        char copyright = '\u00A9'; // the hexadecimal code of the copyright symbol
        try
        {
            Console.SetCursorPosition(x, y); // sets cursor position (int left, int top)
            Console.Write(copyright);  // prints copyright symbol at this position
            Thread.Sleep(200);
        }
        catch (ArgumentOutOfRangeException e) //catches cursor position out of range exception
        {
            Console.Clear(); //clears console
            Console.WriteLine(e.Message); // prints exception message
        }
    }

    public static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode; //sets console encoding to Unicode, 
        // so that copyright symbol can be printed

        char copyright = '\u00A9';

        // Draw the right side of the isosceles triangle, from bottom to top
        // by writing excatly AT the coordinates (x, y)
        for (int x = 19, y = 9; x >= 13; x -= 2, y -= 2)
        {
            WriteAt(copyright, x, y); 
            // calls the WriteAt method for all (x, y) coordinates created by the above for loop
        }

        // Draw the left side of the isosceles triangle, from top to bottom
        // by writing excatly AT the coordinates (x, y)
        for (int x = 11, y = 5; x >= 7; x -= 2, y += 2)
        {
            WriteAt(copyright, x, y);
            // calls the WriteAt method for all (x, y) coordinates created by the above for loop
        }

        // Draw the bottom side of the isosceles triangle, from left to right
        // by writing excatly AT the coordinates (x, y)
        for (int x = 11, y = 9; x <= 15; x += 4)
        {
            WriteAt(copyright, x, y);
            // calls the WriteAt method for all (x, y) coordinates created by the above for loop
        }

        Console.WriteLine();
        Console.CursorVisible = false;
        Console.ReadLine();
    }
}

