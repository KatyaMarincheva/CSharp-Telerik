using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

class TRES4Numbers
{
    static void Main()
    {
        //input
        BigInteger input = BigInteger.Parse(Console.ReadLine());
        int numeralSystem = 9;

        string nineNumber = DecimalToBase(input, numeralSystem);

        Console.WriteLine(toTRES4(nineNumber));

    }

    public static string DecimalToBase(BigInteger decimalNumber, int numeralSystem)
    {
        string result = "";
        do
        {
            BigInteger digit = decimalNumber % numeralSystem;

            if (digit >= 0 && digit <= 9)
            {
                result += (char)(digit + '0');
            }
            else
            {
                result += (char)(digit + '7');
            }
            decimalNumber /= numeralSystem;
        } while (decimalNumber != 0);
        var reversed = result.Reverse(); 
        string output = string.Join("", reversed);
        return output;
    }

    private static readonly Dictionary<char, string> nineToTRES4 = new Dictionary<char, string> 
    {
    { '0', "LON+" },
    { '1', "VK-" },
    { '2', "*ACAD" },
    { '3', "^MIM" },
    { '4', "ERIK|" },
    { '5', "SEY&" },
    { '6', "EMY>>" },
    { '7', "/TEL" },
    { '8', "<<DON" }
    };

    public static string toTRES4(string nine)
    {
        StringBuilder result = new StringBuilder();
        foreach (char c in nine)
        {
            result.Append(nineToTRES4[c]);
        }
        return result.ToString();
    }
}

