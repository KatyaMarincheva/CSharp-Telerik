// Problem 1. Square root

/*  Write a program that reads an integer number and calculates and prints its square root.
        If the number is invalid or negative, print Invalid number.
        In all cases finally print Good bye.
    Use try-catch-finally block.
 */

using System;

class SqareRoot
{
    static void Main()
    {
        try
        {
            // input
            Console.Write("Please, enter an integer number: ");
            int input = int.Parse(Console.ReadLine());

            // set range requirements
            if (input < 0)
                throw new ArgumentOutOfRangeException();

            // calculation
            double root = Math.Sqrt(input);

            // print
            Console.WriteLine("\nSquare root of {0} is {1}.\n", input, root);
        }
            // null input
        catch (ArgumentNullException)
        {
            Console.WriteLine("End of input (Ctrl-Z) detected.");
        }
            // if negative
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Cannot calculate square root of negative number.");
        }
            // if number is not within the range of int type
        catch (OverflowException)
        {
            Console.WriteLine("Input number is too big or too small for int data type.");
        }

            // if not an int number
        catch (FormatException)
        {
            Console.WriteLine("Data entered is not an integer number.");
        }

        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}

