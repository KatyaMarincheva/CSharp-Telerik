﻿// Problem 3. Check for a Play Card

/* Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:

character 	Valid card sign?
5 	        yes
1 	        no
Q 	        yes
q 	        no
P 	        no
10 	        yes
500 	    no
*/

using System;

class CheckForAPlayCard
{
    static void Main()
    {
        // declarations
        byte numeralSymbol;
        char charSymbol;
        bool isChar;
        bool isNumeral;
        string isNot = "The input is not a play card sign.";

        do
        {
            Console.WriteLine("Please, enter a numeral or an upper case char symbol: ");
            string symbol = Console.ReadLine();
            isChar = char.TryParse(symbol, out charSymbol);
            isNumeral = byte.TryParse(symbol, out numeralSymbol);
        } while (!isNumeral && (!isChar || char.IsLower(charSymbol)));

        if (isNumeral)
        {
            switch (numeralSymbol)
            {
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("{0} is a play card sign.", numeralSymbol);
                    break;
                default:
                    Console.WriteLine(isNot);
                    break;
            }
        }
        // if char
        else if (isChar)
        {
            switch (charSymbol)
            {   
                case 'J':
                case 'Q':
                case 'K':
                case 'A':
                    Console.WriteLine("{0} is a play card sign.", charSymbol);
                    break;
                default: Console.WriteLine(isNot);
                    break;
            }

        }

        else Console.WriteLine(isNot);
    }
}

