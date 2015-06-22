// Problem 19. Dates from text in Canada

/*  Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
    Display them in the standard date format for Canada.
 */

using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

class DatesFromTextInCanada
{
    static void Main()
    {
        // input
        string inputText = "Thomas Harris (born 11.04.1940) is an American author and screenwriter, best known for a series of suspense novels about his most famous character, Hannibal Lecter. ";

        // regex with expected date format
        var regex = new Regex(@"\b\d{2}\.\d{2}.\d{4}\b");

        Console.WriteLine("Extracted dates: ");
        // for each match - try to parse
        foreach (Match m in regex.Matches(inputText))
        {
            DateTime dt;
            if (DateTime.TryParseExact(m.Value, "dd.MM.yyyy", null, DateTimeStyles.None, out dt))
            {
                // print in Canadian format
                Console.WriteLine("* " + dt.ToShortDateString().ToString(new CultureInfo("en-CA")));
            }
            Console.WriteLine();
        }
    }
}

