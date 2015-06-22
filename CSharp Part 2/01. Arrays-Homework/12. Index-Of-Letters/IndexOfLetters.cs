// Problem 12. Index of letters

/* Write a program that creates an array containing all letters from the alphabet (A-Z).
    Read a word from the console and print the index of each of its letters in the array.
 */

using System;

class IndexOfLetters
{
    static void Main()
    {
        int index; // this will be the index of the letters in the below char array
        char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        Console.Write("Please, enter a word: ");
        string word = Console.ReadLine().Trim().ToUpper(); // converting to upper case all leters, for comparision purposes

        foreach (char c in word)
        {
            // the index of the letter in the above char array
            // is equal to the difference between ASCII code of the letter and the ASCII code of A
            index = (int)c - (int)'A'; 
            Console.Write("{0} ", index);
        }
        Console.WriteLine();
    }
}

