// Problem 3. Day of week

/*    Write a program that prints to the console which day of the week is today.
      Use System.DateTime.
 */

using System;
using System.Globalization;
using System.Threading;

class DayOfWeek
{
    static void Main()
    {
        // input
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        Console.WriteLine("Please, insert the current date, month and year in a DD.MM.YYYY format: ");
        string currentYear = Console.ReadLine();
        Console.WriteLine("It's {0:dd.MM.yyyy}", currentYear);

        // this time the DateTime object is created by parsing the input string
        DateTime dt = DateTime.Parse(currentYear);
        Console.WriteLine("The day of the week for {0:dd.MM.yyyy} is {1}.", dt, dt.DayOfWeek);
    }
}

