// Problem 8. Digit as Word

/* Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
   Print “not a digit” in case of invalid input.
   Use a switch statement.

Examples:
 d 	    result
 2 	    two
 1 	    one
 0 	    zero
 5 	    five
-0.1 	not a digit
hi 	    not a digit
 9 	    nine
10 	    not a digit
 */
using System;

class DigitAsWord
{
    static void Main()
    {
        // intro
        string intro = @"This program asks for a digit (0-9), 
and depending on the input, shows the digit as a word.";
        Console.WriteLine(intro);

        // declarations
        byte digit;
        bool isDigit;

        // input
        Console.Write("\nPlease, enter a digit (0-9): ");
        isDigit = byte.TryParse(Console.ReadLine(), out digit);

        // logic
        if (isDigit)
        {
            switch (digit)
            {
                case 0:
                    {
                        Console.WriteLine("\nzero\n");
                        break;
                    }

                case 1:
                    {
                        Console.WriteLine("\none\n");
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("\ntwo\n");
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine("\nthree\n");
                        break;
                    }

                case 4:
                    {
                        Console.WriteLine("\nfour\n");
                        break;
                    }

                case 5:
                    {
                        Console.WriteLine("\nfive\n");
                        break;
                    }

                case 6:
                    {
                        Console.WriteLine("\nsix\n");
                        break;
                    }

                case 7:
                    {
                        Console.WriteLine("\nseven\n");
                        break;
                    }

                case 8:
                    {
                        Console.WriteLine("\neight\n");
                        break;
                    }

                case 9:
                    {
                        Console.WriteLine("\nnine\n");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("\nnot a digit\n");
                        break;
                    }
            }
        }

        else
        {
            Console.WriteLine("\nnot a digit\n");
        }
    }
}

