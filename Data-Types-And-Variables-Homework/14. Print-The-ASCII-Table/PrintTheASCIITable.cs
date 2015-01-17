// Problem 14.* Print the ASCII Table

// Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
// Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.
//Note: You may need to use for-loops (learn in Internet how).

using System;
using System.Text;

class PrintTheASCIITable
{
    static void Main()
    {
        // set console window and buffer size
        Console.SetBufferSize(100, 500);
        Console.SetWindowSize(100, 41);

        // set console output encoding
        Console.OutputEncoding = Encoding.Unicode;

        // loop over the decimal codes of the ASCII table ( 0 to 255 ), and print the corresponding char
        Console.WriteLine("ASCII Table\n");
        for (int i = 0; i <= 255; i++)
        {
            char symbol = (char)i;
            Console.WriteLine("ASCII symbol {0} \tand its corresponding decimal code {1}", symbol, i);
        }

        /* Please note the following printing "anomalies":
         * decimal code 9   corresponds to       \t   (tab escape sequence)     
         * decimal code 10   corresponds to      \n   (new line escape sequence)  
         * decimal code 13   corresponds to      \r   (carriage return escape sequence)  
         */

        // uses same approach to print the Bulgarian Alphabet
        Console.WriteLine("\n\nBulgarian Alphabet\n");
        for (int i = 1040; i <= 1103; i++)
        {
            char symbol = (char)i;
            Console.WriteLine("ASCII symbol {0} \tand its corresponding decimal code {1}", symbol, i);
        }
    }
}

