//Problem 5. The Biggest of 3 Numbers

/* Write a program that finds the biggest of three numbers.

Examples:
 a 	    b 	    c 	    biggest
 5 	    2 	    2 	    5
-2 	   -2 	    1 	    1
-2  	4 	    3 	    4
 0 	   -2.5 	5 	    5
-0.1   -0.5  -1.1 	 -0.1
 */

using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        // intro
        string intro = "This program finds the biggest of three numbers.";
        Console.WriteLine(intro);

        // input
        Console.Write("\nPlease, enter a value for a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please, enter a value for b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please, enter a value for c: ");
        double c = double.Parse(Console.ReadLine());

        // logic
        double biggest = double.MinValue;
        
        if (a > biggest)
        {
            biggest = a;
        }
        if (b > biggest)
        {
            biggest = b;
        }
        if (c > biggest)
        {
            biggest = c;
        }

        Console.WriteLine("\nThe biggest value entered is {0}\n", biggest);
    }
}

