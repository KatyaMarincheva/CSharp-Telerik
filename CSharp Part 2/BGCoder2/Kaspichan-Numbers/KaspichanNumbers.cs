using System;
using System.Collections.Generic;
using System.Text;

class ConvertTo256NumeralSystem
{
    static void Main()
    {
        string[] digits = BuildDigits();
        ulong number = ulong.Parse(Console.ReadLine());
        string convertedNumber = ConvertNumberToBase(number, 256, digits);
        Console.WriteLine(convertedNumber);
    }

    private static string[] BuildDigits()
    {
        List<string> digits = new List<string>();
        for (char digit = 'A'; digit <= 'Z'; digit++)
        {
            digits.Add("" + digit);
        }
        for (char prefix = 'a'; prefix <= 'z'; prefix++)
        {
            for (char suffix = 'A'; suffix <= 'Z'; suffix++)
            {
                string digit = "" + prefix + suffix;
                digits.Add(digit);
            }
        }
        return digits.ToArray();
    }

    private static string ConvertNumberToBase(
        ulong number, ulong numberBase, string[] digits)
    {
        StringBuilder resultDigits = new StringBuilder();
        do
        {
            ulong remainder = number % numberBase;
            string nextDigit = digits[remainder];
            resultDigits.Insert(0, nextDigit);
            number = number / numberBase;
        } while (number > 0);
        string result = resultDigits.ToString();
        return result;
    }
}

