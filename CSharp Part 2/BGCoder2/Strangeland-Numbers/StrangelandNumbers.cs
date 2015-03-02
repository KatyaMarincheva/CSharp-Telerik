using System;
using System.Linq;
using System.Numerics;
using System.Text;

class StrangelandNumbers
{
    static void Main()
    {
        string[] alpha = { "f", "bIN", "oBJEC", "mNTRAVL", "lPVKNQ", "pNWE", "hT" };
        var input = Console.ReadLine();
        var currLetter = new StringBuilder();
        BigInteger result = 0;
        foreach (var c in input)
        {
            currLetter.Append(c);
            if (alpha.Contains(currLetter.ToString()))
            {
                int currDigit = Array.IndexOf(alpha, currLetter.ToString());
                result *= 7;
                result += currDigit;
                currLetter.Clear();
            }
        }
        Console.WriteLine(result);
    }
}

