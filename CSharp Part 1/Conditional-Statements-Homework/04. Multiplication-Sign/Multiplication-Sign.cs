//Problem 4. Multiplication Sign

/*Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
        Use a sequence of if operators.

Examples:
 a 	    b 	    c 	    result
 5 	    2 	    2 	    +
-2 	   -2 	    1 	    +
-2 	    4 	    3 	    -
 0 	   -2.5 	4 	    0
-1     -0.5    -5.1 	-
 */

using System;

class Program
{
    static void Main()
    {
        // declarations
        int signCounter = 0;
        string intro = @"This program shows the sign (+, - or 0) of the product of three real numbers, 
without calculating it.";

        // intro
        Console.WriteLine(intro);

        // input
        Console.Write("\nPlease, enter a value for a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please, enter a value for b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Please, enter a value for c: ");
        int c = int.Parse(Console.ReadLine());
        
        // logic
        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("\nThe product of numbers {0}, {1}, and {2} is 0\n", a, b, c);
        }

        else
        {
            if (a < 0)
            {
                signCounter++;
            }
            if (b < 0)
            {
                signCounter++;
            }
            if (c < 0)
            {
                signCounter++;
            }

            if (signCounter%2 == 0)
            {
                Console.WriteLine("\nNumbers: {0}, {1}, and {2}; sign of product: - \n", a, b, c);
            }
            else
            {
                Console.WriteLine("\nNumbers: {0}, {1}, and {2}; sign of product: - \n", a, b, c);
            }
        }
    }
}

