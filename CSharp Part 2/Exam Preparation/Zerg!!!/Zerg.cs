using System;
using System.Collections.Generic;
using System.Text;

class Zerg
{
    static void Main()
    {
        string input = Console.ReadLine();
        string strNum = multiToHex(input).ToString();

        Console.WriteLine(ConvertToDec(strNum, 15));
    }
    // to dec
    public static ulong ConvertToDec(string number, int baseFrom)
    {
        ulong decNum = 0;
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] > '9') // if a char digit is > '9', it can only be 'A', 'B', etc. 
            //from the hexadecimal numeral system
            {
                decNum += (ulong)(number[i] - '7') * (ulong)Math.Pow(baseFrom, (number.Length - 1 - i));
                // example: 'A' = 65 (ASCII code); '7' = 55; hence 'A' - '7' = 10, 
                // which is exactly the decimal representation of the digit A
            }
            else
            {
                decNum += (ulong)(number[i] - '0') * (ulong)Math.Pow(baseFrom, (number.Length - 1 - i));
                // example: '9' = 57 (ASCII code); '0' = 48; hence '9' - '0' = 9, 
                // which is exactly the decimal value of the digit 9
            }
        }
        return decNum;
    }

    // to hex
    private static StringBuilder multiToHex(string multiverse)
    {
        StringBuilder multiNum = new StringBuilder();

        for (int i = 0; i < multiverse.Length; i += 4)
        {
            multiNum.Append(multiverseToHex[multiverse.Substring(i, 4)]);
        }
        return multiNum;
    }

    private static readonly Dictionary<string, char> multiverseToHex = new Dictionary<string, char> 
    {
    { "Rawr", '0' },
    { "Rrrr", '1' },
    { "Hsst", '2' },
    { "Ssst", '3' },
    { "Grrr", '4' },
    { "Rarr", '5' },
    { "Mrrr", '6' },
    { "Psst", '7' },
    { "Uaah", '8' },
    { "Uaha", '9' },
    { "Zzzz", 'A' },
    { "Bauu", 'B' },
    { "Djav", 'C' },
    { "Myau", 'D' },
    { "Gruh", 'E' }
    };
}

