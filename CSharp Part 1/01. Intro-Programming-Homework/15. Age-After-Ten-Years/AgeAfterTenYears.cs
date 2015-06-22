// Problem 15.* Age after 10 Years - 
// Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;
using System.Globalization; // allows the use of (contains) the CultureInfo class
using System.Text; // allows the use of (contains) the StringBuilder class

class AgeAfterTenYears
{
    static void Main()

    {
        Console.Title = "Age after 10 years";

        // the below BufferSize/Window size format will allow me to see all the text without the need of scrolling
        Console.SetWindowSize(45, 20);
        Console.SetBufferSize(45, 60);

        /* The DateTime.Now Property 
         * gets a DateTime object that is set to the current date and time on this computer, expressed as the local time.
         Per default it will get the date in the MM/dd/yyyy format which is not the locally used date format*/
        DateTime todaysDate = DateTime.Now;

        // with "dd/MM/yyyy" I set the DateTime.Now result to my chosen date format
        Console.WriteLine("Today is: {0}", (todaysDate.ToString("dd/MM/yyyy")));

        Console.WriteLine("\nPlease, type below the date of your birthday in the format dd/MM/yyyy and press Enter:\n");

        /* with the next two lines of code I add a predefined filed for typing the birthday date, 
         * and I set the cursor position to be at the beginning of this predifined */
        Console.WriteLine("__/__/____");
        Console.SetCursorPosition(0, 5);

        string format = "dd/MM/yyyy"; // I will need the format string as one of the required DateTime.ParseExact arguments 
        string input  = (Console.ReadLine()); // Reads the birthday date input string from the console
        /* the StringBuilder.Replace method below is said to be fast method for replacing unwanted parts of the initial input string
         * (in this case empty spaces, commas, dashes, etc. with "/" so that the chosen date format is achieved */
        StringBuilder b = new StringBuilder(input);
        b.Replace(" ", "/"); // replace " " with "/", etc.
        b.Replace("-", "/");
        b.Replace(",", "/");
        b.Replace("_", "/");
        b.Replace("\t", "/");
        string inputFormatted = b.ToString(); // returns the re-formatted input birthday date string

        Console.WriteLine("\nDate Format: {0}", inputFormatted);

        /* Now that the inputFormatted birthday date string already complies with the chosen date format 
         it is still just a string; For the computer to be able to recognise it as a date, it needs to be converted into a date.
         * I do this using the DateTime.ParseExact method with the respective required arguments*/
        DateTime parsedBirthdayDate = DateTime.ParseExact(inputFormatted, format, CultureInfo.InvariantCulture);

        Console.WriteLine("\nYour birthday is: {0}", parsedBirthdayDate.ToString("dd/MM/yyyy"));

        // DateTime.Year Property gets only the year component of the respective date 
        int yourAgeNow = todaysDate.Year - parsedBirthdayDate.Year;

        /* I use the DateTime.Compare method below checks up if todday's date is before, at, 
         * or after the particular person's birthday date.
         * If, for instance, a person is born in 1985, we will assume that he is now 30 y.o.;
         * if however today is Jan 6 2015, and this person is born on Jan 4 - he will still be 29 y.o. 
         * So, depending on the comparison between today's date and the exact birthday date, 
         * this person's age will be either ("Today's year" -"birthday year"), or ("Today's year" -"birthday year"),*/
        int result = DateTime.Compare(DateTime.Now.AddYears(- yourAgeNow), parsedBirthdayDate);
        {
            if (result < 0)
            {
                Console.WriteLine("\nYou are {0} y.o.", --yourAgeNow);
                // for "Age after 10 years" we just add 10 years to today's age
                Console.WriteLine("\nAfter 10 years you will be {0} y.o.", yourAgeNow + 10); 
            }
            else if (result >= 0)
            {
                Console.WriteLine("\nYou are now {0} y.o.", yourAgeNow);
                Console.WriteLine("\nAfter 10 years you will be {0} y.o.", yourAgeNow + 10);
            }

            Console.CursorVisible = false;
            Console.ReadLine();
        }
    }
}

