// Problem 17. Date in Bulgarian

// Write a program that reads a date and time given in the format: 
//day.month.year hour:minute:second and prints the date and time 
// after 6 hours and 30 minutes (in the same format) 
// along with the day of week in Bulgarian.

using System;
using System.Globalization;
using System.Threading;

class DateDifference
{
    static void Main()
    {
        // making date string input and output independable from local computer settings
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

        // input
        Console.WriteLine("Please, insert the start date and time, \nin the format: \nday.month.year hour:minute:second: ");
        string startTimeTxt = Console.ReadLine();
        DateTime startTime = DateTime.Parse(startTimeTxt);
        Console.WriteLine("\nStart date and time: {0}", startTime);

        // adding 6 hours and 30 minutes 
        DateTime newTime = startTime.AddHours(6.5);

        // printing
        Console.WriteLine("\nTime after 6 hours and 30 minutes: \n{0} {1}\n", newTime.ToString("dddd"), newTime);

    }
}

