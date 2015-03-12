// Problem 1. Exchange If Greater

/* Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.

Examples:
a 	    b 	    result
5 	    2 	    2 5
3 	    4 	    3 4
5.5 	4.5 	4.5 5.5
 */

using System;

class ExchangeIfGreater
{
    static void Main()
    {
        // input
        Console.Write("Enter a value for a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("\nEnter a vallue for b: ");
        double b = double.Parse(Console.ReadLine());

        // condition
        if (a > b)
        {
            // exchanging values
            a = a + b;
            b = a - b;
            a = a - b;

            // printing the result
            Console.WriteLine("{0} is greater than {1}, hence a = {0}, and b = {1}\n", a, b);
        }
        else
        {
            Console.WriteLine("{0} is not greater than {1}, hence a = {0}, and b = {1}\n", a, b);
        }
    }
}

