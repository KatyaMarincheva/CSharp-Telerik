// Problem 14. Modify a Bit at Given Position

/* We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.

Examples:
n 	binary representation of n 	p 	v 	binary result 	result
5 	    00000000 00000101 	    2 	0 	00000000 00000001 	1
0 	    00000000 00000000 	    9 	1 	00000010 00000000 	512
15 	    00000000 00001111 	    1 	1 	00000000 00001111 	15
5343 	00010100 11011111 	    7 	0 	00010100 01011111 	5215
62241 	11110011 00100001 	    11 	0 	11110011 00100001 	62241 */

using System; 

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        string inputN;
        int n;

        string inputP;
        int p;

        string inputV;
        int v;

        string intro = 
    @"This program will modify the number n 
to hold the value v at the position p
from the binary representation of n 
while preserving all other bits in n.";

        Console.WriteLine(intro);

        do  // validates input for n
        {
            Console.Write("\nPlease enter a value for n: ");
            inputN = Console.ReadLine();

        } while (!int.TryParse(inputN, out n));


        // print initial n in table view 
        Console.WriteLine("\n{0,-16} {1,32}", "Initial n:", Convert.ToString(n, 2).PadLeft(32, '0')); 


        do  // validates input for p
        {
            Console.Write("\nPlease enter a value for p: ");
            inputP = Console.ReadLine();

        } while (!int.TryParse(inputP, out p));
        

        do  // validates input for v
        {
            Console.Write("\nPlease enter a bit value v (0 or 1): ");
            inputV = Console.ReadLine();

        } while (!int.TryParse(inputV, out v));

        int mask = 1 << p; // a mask with a bit 1 at the manipulation position

        // (0 | 1) = 1 and (1 | 1) = 1; we guarantee that with no matter what intitial value
        // the final one will be 1
        if (v == 1) 
        {
            n = n | mask;

            // print final n in table view (from Evlogi's lecture)
            Console.WriteLine("\n{0,-16} {1,32}", "Final n:", Convert.ToString(n, 2).PadLeft(32, '0'));
            Console.WriteLine();
        }

        // I will first set the bit value at the manipulation position to 1
        // after that, I will apply the ^(XOR) operator: 1 (in n) ^ 1 (in mask) = 0
        if (v == 0)
        {
            n = n | mask;
            n = n ^ mask;

            // print final n in table view 
            Console.WriteLine("\n{0,-16} {1,32}", "Final n:", Convert.ToString(n, 2).PadLeft(32, '0'));
            Console.WriteLine();
        }
    }
}
    
