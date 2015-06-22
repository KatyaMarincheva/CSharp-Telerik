// Problem 7.* Largest area in matrix

// Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.

/* Example:
matrix 	                    result
1 	3 	2 	2 	2 	4       13
3 	3 	3 	2 	4 	4
4 	3 	1 	2 	3 	3
4 	3 	1 	3 	3 	1
4 	3 	3 	3 	1 	1
	
Hint: you can use the algorithm Depth-first search or Breadth-first search.
 */

using System;
using System.Text;

class LargestAreaInMatrix
{
// input array
 static int[,] matrix = new int[,]
{ {1, 3, 2, 2, 2, 4},
{3, 3, 3, 2, 4, 4},
{4, 3, 1, 2, 3, 3},
{4, 3, 1, 3, 3, 1},
{4, 3, 3, 3, 1, 1} };

// logic
 static bool[,] visited = new bool[matrix.GetLength(0), matrix.GetLength(1)];

    static int DepthFirstSearch(int row, int col, int value)
    {
        if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
        {
            return 0;
        }
        if (visited[row, col])
        {
            return 0;
        }
        if (matrix[row, col] != value)
        {
            return 0;
        }
        visited[row, col] = true;
        return DepthFirstSearch(row, col + 1, value) + DepthFirstSearch(row, col - 1, value) +
        DepthFirstSearch(row + 1, col, value) + DepthFirstSearch(row - 1, col, value) + 1;
    }

    // printing
    static void PrintResult()
    {
        // result
        int result = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                result = Math.Max(result, DepthFirstSearch(row, col, matrix[row, col]));                
            }
        }
        Console.WriteLine("\n{0} equal neighbour elements.\n", result);

        // matrix
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                if (matrix[rows, cols] == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.Write("{0,3}", matrix[rows, cols]);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void Main()
    {
        PrintResult();
    }
}

