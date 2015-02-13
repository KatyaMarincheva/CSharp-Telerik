// Problem 12. Null Values Arithmetic

// Create a program that assigns null values to an integer and to a double variable.
// Try to print these variables at the console.
// Try to add some number or the null literal to these variables and print the result.

using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? nullInt = null; // assigns null value to int nullInt
        double? nullDouble = null; // assigns null value to double nullDouble

        // tries to print the above null values; as we can see, null values do not get printed
        // all we can see printed are the underscores arround the null values
        Console.WriteLine("First variable _{0}_ and second variable _{1}_", nullInt, nullDouble);
        Console.WriteLine(nullDouble + null); // prints nothis, empty line, as the null values do not print
        Console.WriteLine(nullInt + 12); // prints nothis, empty line, as null plus something does not print

        // all we can see printed are the underscores arround the null value
        //as null plus something is null, and does not print
        Console.WriteLine("nullInt = _{0}_", nullInt + 10); 
    }
}

