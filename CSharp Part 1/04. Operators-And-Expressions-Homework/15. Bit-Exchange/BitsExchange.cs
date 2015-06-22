/*  Problem 15.* Bits Exchange

    Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

Examples:
n 	        binary representation of n 	            binary result 	                        result
1140867093 	01000100 00000000 01000000 00010101 	01000010 00000000 01000000 00100101 	1107312677
255406592 	00001111 00111001 00110010 00000000 	00001000 00111001 00110010 00111000 	137966136
4294901775 	11111111 11111111 00000000 00001111 	11111001 11111111 00000000 00111111 	4194238527
5351 	    00000000 00000000 00010100 11100111 	00000100 00000000 00010100 11000111 	67114183
2369124121 	10001101 00110101 11110111 00011001 	10001011 00110101 11110111 00101001 	2335569705  */ 

using System;

class BitsExchange
{
    static void Main()
    {
        string inputN;
        uint n;

        // the homework instruction asks for manipulations on "unsigned integer" (uint)
        // direct calculations with uint n and (1 << position) (1 is per default an int)
        // cause castting errors
        uint one = 1; 
        
        string intro =
    @"This program exchanges bits 3, 4 and 5 with bits
24, 25 and 26 of given 32-bit unsigned integer.";

        Console.WriteLine(intro);

        do  // validates input for n
        {
            Console.Write("\nPlease enter a value for n: ");
            inputN = Console.ReadLine();

        } while (!uint.TryParse(inputN, out n));

        // prints initial n as binary, table view
        Console.WriteLine("\n{0,-16} {1,32}", "Initial n:", Convert.ToString(n, 2).PadLeft(32, '0'));


        // loops over i-positions 3 to 5, and j-positions 24 to 26
        for (byte i = 3, j = 24; i < 6; i++, j++)
            {

            // checks if bit values at i- and j-positions are different
            if (((n >> i) & 1) != ((n >> j) & 1))
            {
                // if bit values at i- and j-positions are different, 
                n = n ^ (one << i); // swaps bit value at position i
                n = n ^ (one << j); // swaps bit value at position j
            }
        }
        // prints final n and n as binary, table view
        Console.WriteLine("\n{0, -16} {1, 32}", "Final n:", Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine("\n{0, -16} {1}\n", "Final n dec.:", n);
    }
}



