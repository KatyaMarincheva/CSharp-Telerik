// Problem 14.* Current Date and Time - Create a console application that prints the current date and time. Find out how in Internet.

using System;

class CurrentDateAndTime
{
    static void Main()
    {
        /* The DateTime.Now Property 
        * gets a DateTime object that is set to the current date and time on this computer, expressed as the local time. */
        Console.Title = "Current Date and Time";

        DateTime dateAndTimeNow = DateTime.Now;

        Console.WriteLine("Current date and time: {0}", dateAndTimeNow);

        Console.CursorVisible = false;
        Console.ReadLine();
    }
}

