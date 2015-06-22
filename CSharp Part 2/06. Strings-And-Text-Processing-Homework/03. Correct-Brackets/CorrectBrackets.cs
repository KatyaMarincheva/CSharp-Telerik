// Problem 3. Correct brackets

/* Write a program to check if in a given expression the brackets are put correctly.

Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
 */

using System;

class CorrectBrackets
{
    static void Main()
    {
        // input arithmetical expression
        Console.Write("Enter string: ");
        string input = Console.ReadLine();

        // apply the CheckBrackets metod
        bool correct = CheckBrackets(input);

        // print result
        Console.WriteLine(correct ? "Brackets are correct" : "Incorrect brackets");
        Console.WriteLine();
    }

    // this method checks for two kinds of irregularities:
    // 1. an aruthmetical expression starting with a closing bracket
    // 2. number of opening brackets not matching the number of closing brackets
    static bool CheckBrackets(string input)
    {
        int counter = 0;
        if (input[0] == ')')
        {
            return false;
        }
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                counter++;
            }
            else if (input[i] == ')')
            {
                counter--;
            }
        }
        if (counter == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

