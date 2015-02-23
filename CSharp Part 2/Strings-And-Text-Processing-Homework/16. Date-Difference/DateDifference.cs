// Problem 16. Date difference

/*    Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

Example:

Enter the first date: 27.02.2006
Enter the second date: 3.03.2006
Distance: 4 days
 */

using System;
using System.Globalization;
using System.Threading;

class DateDifference
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

        // input
        Console.WriteLine("Please, insert the start date, month and year \nin a DD.MM.YYYY format: ");
        string startDateTxt = Console.ReadLine();
        DateTime startDate = DateTime.Parse(startDateTxt);

        Console.WriteLine("\nPlease, insert the end date, month and year \nin a DD.MM.YYYY format: ");
        string endDateTxt = Console.ReadLine();
        DateTime endDate = DateTime.Parse(endDateTxt);

        // calculating time span
        TimeSpan remainingDays = endDate - startDate;

        // printing
        Console.WriteLine("\nYou have " + remainingDays.TotalDays + " days left.\n"); 
    }
}

