// Problem 2. Random numbers

// Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class RandomNumbers
{
    static void Main()
    {
        // creating the rnd object, using the  Random class
        Random rnd = new Random();

        // printing one new random number at every loop
        Console.WriteLine("10 random integers from 100 to 200:");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write("{0,4}", rnd.Next(100, 201));
        }
        Console.WriteLine();
    }
}

