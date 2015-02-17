// Problem 3. English digit

/* Write a method that returns the last digit of given integer as an English word.

Examples:
input 	output
512 	two
1024 	four
12309 	nine
 */

using System;

class EnglishDigit
{
    static void Main()
    {
        // input
        Console.Write("Please, enter a number: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("\nThe last digit of the input number is {0}.\n", GetDigit(num));
    }

    static string GetDigit(int number)
    {
        string[] array = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        
        int digit = number % 10;
        string engDigit = array[digit];

        return engDigit;
    }
}

