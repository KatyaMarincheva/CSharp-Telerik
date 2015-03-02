using System;
using System.Collections.Generic;
using System.Text;

class MultiverseCommunication
{
    static void Main()
    {
        string input = Console.ReadLine();
        string strNum = multiToHex(input).ToString();

        Console.WriteLine(ConvertToDec(strNum, 13));
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

        for (int i = 0; i < multiverse.Length; i += 3)
        {
            multiNum.Append(multiverseToHex[multiverse.Substring(i, 3)]);
        }
        return multiNum;
    }

    private static readonly Dictionary<string, char> multiverseToHex = new Dictionary<string, char> 
    {
    { "CHU", '0' },
    { "TEL", '1' },
    { "OFT", '2' },
    { "IVA", '3' },
    { "EMY", '4' },
    { "VNB", '5' },
    { "POQ", '6' },
    { "ERI", '7' },
    { "CAD", '8' },
    { "K-A", '9' },
    { "IIA", 'A' },
    { "YLO", 'B' },
    { "PLA", 'C' }
    };
}

