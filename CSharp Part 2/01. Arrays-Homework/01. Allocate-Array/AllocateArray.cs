// Problem 1. Allocate array

/* Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
   Print the obtained array on the console.
 */

using System;

class AllocateArray
{
    static void Main()
    {
        // Declaring the array
        int[] array = new int[20];

        // Filing the array
        for (int i = 0; i < 20; i++)
        {
            array[i] = i * 5;
        }

        // prepare for printing, and print
        string arrayContent = String.Join(", ", array);
        Console.WriteLine(arrayContent);
    }
}

