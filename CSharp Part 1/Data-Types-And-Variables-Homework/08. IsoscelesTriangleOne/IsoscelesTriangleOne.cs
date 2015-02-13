using System;
using System.Text;
using System.Threading;

class Sample
{
    protected static void WriteAt(char copiright, int x, int y)
    {
        Console.SetWindowSize(27, 13);
        Console.SetBufferSize(27, 13);

        char copyright = '\u00A9';

        try
        {
            Console.SetCursorPosition(x, y);
            Console.Write(copyright);
            Thread.Sleep(200);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.Clear();
            Console.WriteLine(e.Message);
        }
    }

    class IsoscelesTriangleOne
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            char copyright = '\u00A9';

            // Draw the right side of the isosceles triangle, from bottom to top.
            WriteAt(copyright, 19, 9);
            WriteAt(copyright, 17, 7);
            WriteAt(copyright, 15, 5);
            WriteAt(copyright, 13, 3);

            // Draw the left side of the isosceles triangle, from top to bottom.
            WriteAt(copyright, 11, 5);
            WriteAt(copyright, 9, 7);
            WriteAt(copyright, 7, 9);

            // Draw the bottom side of the isosceles triangle, from left to right.
            WriteAt(copyright, 11, 9);
            WriteAt(copyright, 15, 9);

            Console.WriteLine();
            Console.CursorVisible = false;
            Console.ReadLine();
        }
    }
}


