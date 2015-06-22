// Problem 7. Sort 3 Numbers with Nested Ifs

/*Write a program that enters 3 real numbers and prints them sorted in descending order.
        Use nested if statements.

Note: Don’t use arrays and the built-in sorting functionality.

Examples:
a 	    b 	    c 	    result
 5 	    1 	    2 	    5 2 1
-2 	   -2 	    1 	    1 -2 -2
-2 	    4 	    3 	    4 3 -2
 0 	   -2.5 	5 	    5 0 -2.5
-1.1   -0.5  -0.1 	    -0.1 -0.5 -1.1
10 	    20 	   30 	    30 20 10
 1 	    1 	    1 	    1 1 1
 */
using System;

class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        // intro
        string intro = @"This program enters 3 real numbers 
and prints them sorted in descending order.";
        Console.WriteLine(intro);

        // input
        Console.Write("\nPlease, enter a value for a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please, enter a value for b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please, enter a value for c: ");
        double c = double.Parse(Console.ReadLine());

        // logic
        double first = double.MinValue;
        double second = double.MinValue;
        double third = double.MinValue;

        if (a > first)
        {
            first = a;

            if (b > c)
            {
                second = b;
                third = c; ;
            }
            else
            {
                second = c;
                third = b;
            }
        }
        if (b > first)
        {
            first = b;

            if (a > c)
            {
                second = a;
                third = c; ;
            }
            else
            {
                second = c;
                third = a;
            }
        }
        if (c > first)
        {
            first = c;

            if (a > b)
            {
                second = a;
                third = b; ;
            }
            else
            {
                second = b;
                third = a;
            }
        }

        Console.WriteLine("\nThe three numbers in descending order are: {0} {1} {2}\n", first, second, third);
    }
}
