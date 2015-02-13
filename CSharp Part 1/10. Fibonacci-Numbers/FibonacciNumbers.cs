// Problem 10. Fibonacci Numbers

/* Write a program that reads a number n 
 * and prints on the console the first n members 
 * of the Fibonacci sequence 
 * (at a single line, separated by comma and space - ,): 
 * 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
Note: You may need to learn how to use loops.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FibonacciNumbers
{
    static void Main()
    {
        Console.SetBufferSize(100, 100);
        Console.SetWindowSize(100, 30);
        
        string intro =
@"This program  reads a number n and prints on the console the first n members 
of the Fibonacci sequence, using the formula: 

Xn = (phi^n - (1 - phi)^n)/sqrt(5)";
        Console.WriteLine(intro);

        string input;
        int n;

        do // validates input for n
        {
            Console.Write("\nPlease, enter a value for n: ");
            input = Console.ReadLine();

        } while (!int.TryParse(input, out n));

        double[] nums = new double[n];

        double goldenRatio = (1 + Math.Sqrt(5)) / 2; // formula for phi (the golden ratio number)

        // calculates sequence [0...n], and stores it into the nums array
        for (int i = 0; i < n; i++)
        {
            double member = (int)((Math.Pow(goldenRatio, i) - Math.Pow((1 - goldenRatio), i)) / Math.Sqrt(5));
               nums[i] = Math.Round(member);
        }

        // prints sequence
        Console.WriteLine("\nThe first {0} members of the Fibonacci sequence are:\n{1}\n", n, string.Join(", ", nums.ToArray()));
    }
}

