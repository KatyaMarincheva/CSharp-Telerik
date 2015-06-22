using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

    class DurankulakNumbers
    {
        static void Main()
        {
        string[] digits = BuildDigits();
        string input = Console.ReadLine();

        // build number-string, match them with digits array, if a match 
        // - convert the position number from 168-base to 10-base
        var currLetter = new StringBuilder();
        BigInteger result = 0;
        foreach (var c in input)
        {
            currLetter.Append(c);
            if (digits.Contains(currLetter.ToString()))
            {
                int currDigit = Array.IndexOf(digits, currLetter.ToString());
                result *= 168;
                result += currDigit;
                currLetter.Clear();
            }
        }
        Console.WriteLine(result);
        }

        // build array of digits
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
}

