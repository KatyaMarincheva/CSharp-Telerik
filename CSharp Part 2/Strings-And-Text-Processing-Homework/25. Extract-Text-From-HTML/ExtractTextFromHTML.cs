// Problem 25. Extract text from HTML

/* Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

Example input:

<html>
  <head><title>News</title></head>
  <body><p><a href="http://academy.telerik.com">Telerik
    Academy</a>aims to provide free real-world practical
    training for young people who want to turn into
    skilful .NET software engineers.</p></body>
</html>
 
Output:

Title: News

Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.
 */

using System;
using System.Text.RegularExpressions;

class ExtractTextFromHTML
{
    static void Main()
    {
        // input
        string htmlDoc = @"<html>
  <head><title>News</title></head>

  <body><p><a href=""http://academy.telerik.com"">Telerik Academy</a> aims to provide free real-world practical
  training for young people who want to turn into
  skilful .NET software engineers.</p></body>
</html>";
        Console.WriteLine(htmlDoc); 

        // output
        Console.WriteLine("\nTags removed:");
        Console.WriteLine(StripTagsRegex(htmlDoc));
        Console.WriteLine();
    }

    // replace tags with empty strings
    public static string StripTagsRegex(string source)
    {
        return Regex.Replace(source, "<.*?>", string.Empty);
    }
}

