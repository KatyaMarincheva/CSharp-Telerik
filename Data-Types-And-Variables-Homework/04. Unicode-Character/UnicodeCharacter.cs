// Problem 4. Unicode Character

// Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.
// Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. The output should be *.

using System;

class UnicodeCharacter
{
    static void Main()
    {
        char x = '\u002A'; // declares char x and assigns it Unicode code 42
        // only please note, that 42 is the decimal value, while Unicode codes are hexadecimal values
        // and the hexadecimal value corresponding to the decimal 42 is 2A
        Console.WriteLine(x);  // prints char x
        Console.ReadLine();
    }
}

