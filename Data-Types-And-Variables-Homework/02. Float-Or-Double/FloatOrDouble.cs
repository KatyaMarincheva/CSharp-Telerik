// Problem 2. Float or Double?

// Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
// Write a program to assign the numbers in variables and print them to ensure no precision is lost.

using System;
using System.Globalization;  //allows the use of the Thread.CurrentCulture Property 

class FloatOrDouble
{
    static void Main()
    {
        // sets custom floating point/ decimal number format (00.00 instead of 00,00)
        // overrides the local floating point/ decimal number format settings of the user's computer
        CultureInfo en = new CultureInfo("en-US");

        double numberOne = 34.567839023;
        float numberTwo = 12.345f; 
        double numberThree = 8923.1234857;
        float numberFour = 3456.091f;

        // the .GetType().Name method gets the type of a variable
        Console.WriteLine("{0} {1} \n{2} {3} \n{4} {5} \n{6} {7}", numberOne.GetType().Name, numberOne, numberTwo.
            GetType().Name, numberTwo, numberThree.GetType().Name, numberThree, numberFour.GetType().Name, numberFour);

        Console.WriteLine("\nData type information: \n\nSingle -> alias of float\n");
    }
}
