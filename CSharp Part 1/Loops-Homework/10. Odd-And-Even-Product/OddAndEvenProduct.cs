// Problem 10. Odd and Even Product

/* You are given n integers (given in a single line, separated by a space).
   Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
   Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

Examples:
numbers 	result
2 1 1 6 3 	yes
product = 6 	
	
3 10 4 6 5 1 	yes
product = 60 	
	
4 3 2 5 2 	no
odd_product = 16 	
even_product = 15 	
    */

using System;

class OddAndEvenProduct
{
    static void Main()
    {
        // intro
        string intro = @"This program checks whether the product of the odd elements
is equal to the product of the even elements.";
        Console.WriteLine(intro);
        
        // declarations
        string input;
        int productOdd = 1;
        int productEven = 1;

        // input
        Console.Write("\nPlease, enter 5 numbers in a single line: ");
        input =  Console.ReadLine();
        string[] numStr = input.Split(' '); // splits entry into array of strings
        int[] nums = new int[numStr.Length]; // second, int array, ready to store the parsed number strings

        // logic
        for (int i = 0; i < numStr.Length; i++)
        {
            nums[i] = int.Parse(numStr[i]); // parsing number strings into numbers, just to be able to display them
            
            // the odd elements (1, 3, etc.) are at index 0, 2, etc.; so if the index is even, the element will be odd
            if (i % 2 == 0)
            {
                productOdd *= nums[i]; // product of odd elements
            }

            else
            {
                productEven *= int.Parse(numStr[i]); // product of even elements
            }
        }

        // printing and evaluation
        Console.WriteLine("\nNumbers: {0}", String.Join(", ", nums));
        Console.WriteLine("Product of the odd elements: {0}", productOdd);
        Console.WriteLine("Product of the even elements: {0}", productEven);

        // display Yes for equal products, No if the products of odd and even elements are not equal
        Console.WriteLine("The product of the odd elements is equal to the product of the even elements: {0}\n", (productOdd == productEven)? "yes" : "no");
    }
}

