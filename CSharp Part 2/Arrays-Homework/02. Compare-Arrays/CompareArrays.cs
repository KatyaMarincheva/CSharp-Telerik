// Problem 2. Compare arrays

// Write a program that reads two integer arrays from the console and compares them element by element.

using System;
using System.Collections.Generic;
using System.Linq;

class CompareArrays
{
    static void Main()
    {
        // input values for array length
        Console.Write("Please, enter how many elements Array One will have: ");
        int size1 = int.Parse(Console.ReadLine());

        Console.Write("Please, enter how many elements Array Two will have: ");
        int size2 = int.Parse(Console.ReadLine());
        Console.WriteLine();

        // Declarations
        int[] array1 = new int[size1];
        int[] array2 = new int[size2];
        bool isEqual = true;
        int size;

        // if the two arrays are of different length - they are different, no further checking necessary
        if (size1 != size2)
        {
            isEqual = false;
        }

        // if the arrays will of equal length - we fill the arrays
        // and start comparing them element by element
        else
        {
            size = size1 = size2;
            // Filling array one
            for (int i = 0; i < size; i++)
            {
                Console.Write("array1[{0}] = ", i);
                array1[i] = int.Parse(Console.ReadLine());
            }

            // Filling array two
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                Console.Write("array2[{0}] = ", i);
                array2[i] = int.Parse(Console.ReadLine());
            }

            // checking up if the elements of array1 and array2 have equal values at equal positions
            for (int i = 0; i < size; i++)
            {
                if (array1[i] != array2[i])
                {
                    isEqual = false;
                    break;
                }
            }

            // preparing for printing
            string array1Elements = string.Join(", ", array1);
            string array2Elements = string.Join(", ", array2);

            // printing the arrays
            Console.WriteLine("\nArray One elements: {0}", array1Elements);
            Console.WriteLine("Array Two elements: {0}", array2Elements);
        }

        // printing the result
        Console.WriteLine( isEqual ? "Array One and Array Two are equal.\n" : "Array One and Array Two are not equal.\n");
    }
}

