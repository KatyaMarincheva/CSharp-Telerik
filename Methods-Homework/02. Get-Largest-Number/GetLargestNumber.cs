// Problem 2. Get largest number

/* Write a method GetMax() with two parameters that returns the larger of two integers.
   Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
 */

using System;

public class GetLargestNumber
{
    static void Main()
    {
        // input
        Console.Write("Please, enter first number: ");
        double first = double.Parse(Console.ReadLine());
        Console.Write("Please, enter second number: ");
        double second = double.Parse(Console.ReadLine());
        Console.Write("Please, enter third number: ");
        double third = double.Parse(Console.ReadLine());

        Console.Write("The largest of the three numbers is: ");
        // apply GetMax method to first and second number, and again
        // apply GetMax method on the result of the above and third number
        Console.WriteLine(GetMax(GetMax(first, second), third));
    }

    public static double GetMax(double number1, double number2)
    {
        if (number2 > number1)
        {
            return number2;
        }
        else
        {
            return number1;
        }
    }
}

