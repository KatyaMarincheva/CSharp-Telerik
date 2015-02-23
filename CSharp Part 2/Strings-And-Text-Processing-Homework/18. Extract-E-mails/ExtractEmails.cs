// Problem 18. Extract e-mails

/*  Write a program for extracting all email addresses from given text.
    All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
 */

﻿using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        // input
        Console.WriteLine("Please enter below text containing one or more emails:");
        string text = "Email examples example@abv.bg or john.johnson@outlook.com are valid.These emails: example@yahoo. @academy.com how@you. are not valid.";
        string[] emails = text.Split(new[] { " ", ";", ",", ". " }, StringSplitOptions.RemoveEmptyEntries);

        // check all the text for e-mails
        string[] validEmails = Array.FindAll(emails, IsValidEmail);

        // print e-mails
        PrintEmails(validEmails);
    }

    // using e-mail validator regex: http://regexlib.com/REDetails.aspx?regexp_id=26&AspxAutoDetectCookieSupport=1
    static bool IsValidEmail(string email)
    {
        const string pattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
        @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
        @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        return new Regex(pattern).IsMatch(email);
    }

    // print e-mails
    static void PrintEmails(string[] validEmails)
    {
        Console.WriteLine("\nExtracted e-mail addresses from the sample text: ");
        foreach (string email in validEmails)
        {
            Console.WriteLine("* " + email);
        }
        Console.WriteLine("\n");
    }
}

