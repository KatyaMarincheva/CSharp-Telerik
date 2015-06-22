// Problem 9. Sum of n Numbers

/*Write a program that enters a number n 
 * and after that enters more n numbers and 
 * calculates and prints their sum. 
 * Note: You may need to use a for-loop.
 */

using System;
using System.Globalization;
using System.Linq;
using System.Threading;

class SumOfNNumbers
{
    static void Main()
    {
        // allows me to instruct the console to read the dot as decimal point 
        // in floating-point type numbers
        CultureInfo en = new CultureInfo("en-US");
        Thread.CurrentThread.CurrentCulture = en;

        // how many number will you be entering?
        Console.Write("\nPlease, enter a value for array length: ");
        int length = int.Parse(Console.ReadLine());

        // we create an array (list) with a number of empty slots equal to the above number length
        double[] nums = new double[length];

        Console.Write("\nPlease, enter the first number: ");
        nums[0] = double.Parse(Console.ReadLine());

        Console.Write("\nPlease, enter the second number: ");
        nums[1] = double.Parse(Console.ReadLine());

        Console.Write("\nPlease, enter the third number: ");
        nums[2] = double.Parse(Console.ReadLine());

        Console.Write("\nPlease, enter the forth number: ");
        nums[3] = double.Parse(Console.ReadLine());

        Console.Write("\nPlease, enter the fifth number: ");
        nums[4] = double.Parse(Console.ReadLine());

        Console.WriteLine("\nThe Max of these 5 numbers is {0}\n", nums.Max());
        Console.WriteLine("\nThe Min of these 5 numbers is {0}\n", nums.Min());
        Console.WriteLine("\nThe sum of these 5 numbers is {0}\n", nums.Sum());
        Console.WriteLine("\nThe average of these 5 numbers is {0}\n", nums.Average());
    }
}

