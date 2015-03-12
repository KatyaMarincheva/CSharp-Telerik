
// Problem 2. Enter numbers

/*  Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
        If an invalid number or non-number text is entered, the method should throw an exception.
    Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
 */

using System;

class ReadNumbers
{
    static int ReadNumber(int start, int end)
    {
        int input = int.Parse(Console.ReadLine());
        if (input <= start || input >= end)
            throw new ArgumentOutOfRangeException();
        return input;
    }

    static void Main()
    {
        int[] array = new int[10];
        Console.WriteLine("Please, enter 10 numbers (0 < i < 100) in increasing order: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Please, enter number {0}: ", i + 1);
            try
            {
                // updating the number input range requirements, so that a1 < a2, etc.
                if (i == 0)
                    array[i] = ReadNumber(0, 90 + i);
                else
                    array[i] = ReadNumber(array[i - 1], 90 + i);
            }

                // catch OverflowException as result of parsing
            catch (OverflowException)
            {
                Console.WriteLine("Input number is too big or too small to fit in int data type");
            }

                // catch ArgumentOutOfRangeException if number doesn't fall into the set range requirement
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Number must be in range {0} - {1}. Try again."
                , i == 0 ? 0 : array[i - 1] + 1, 90 + i);
                i--;
                continue;
            }

                // input cannot be converted into int
            catch (FormatException)
            {
                Console.WriteLine("Cannot convert this input to int. Try again.");
                i--;
                continue;
            }
        }
    }
}


