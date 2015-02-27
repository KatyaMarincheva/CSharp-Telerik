// Problem 5. Maximal area sum

/*  Write a program that reads a text file containing a square matrix of numbers.
    Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
        The first line in the input file contains the size of matrix N.
        Each of the next N lines contain N numbers separated by space.
        The output should be a single number in a separate text file.

Example:
input 	output
4
2 3 3 4
0 2 3 4
3 7 1 2
4 3 3 2 	17
 */

using System;
using System.IO;

class MaximalAreaSum
{
    static int[,] ReadMatrix()
    {
        int matrixSize = 0;
        int[,] matrix;


        using (StreamReader reader = new StreamReader(@"..\..\matrix.txt")) // this code "@"..\..\" retrieves files in same folder as the program .cs file
        {
            string s = reader.ReadLine();         // read matrix input from file
            if (!int.TryParse(s, out matrixSize)) // parse the input
            {
                throw new FormatException();
            }
            matrix = new int[matrixSize, matrixSize];
            int[] matrixRow = new int[matrixSize];
            string[] strRow = new string[matrixSize];
            for (int i = 0; i < matrixSize; i++)
            {
                s = reader.ReadLine(); // read next line of matrix input from file
                strRow = s.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    for (int j = 0; j < matrixSize; j++)
                        matrix[i, j] = int.Parse(strRow[j]); // parse each input number
                }
                catch (FormatException ex)
                {
                    throw new FormatException(i + 1.ToString(), ex);
                }
                catch (IndexOutOfRangeException ex)
                {
                    throw new IndexOutOfRangeException(i + 1.ToString(), ex);
                }
            }
        }
        return matrix;
    }

    // print matrix
    private static void PrintMatrix(int[,] matrix, int maxRow, int maxCol)
    {
        string divider = "+";
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
            divider = divider + "---+";
        Console.WriteLine(divider);
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                Console.Write("|");
                if (rows >= maxRow && rows <= maxRow + 1 && cols >= maxCol && cols <= maxCol + 1)
                    Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("{0,3}", matrix[rows, cols]);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine("|");
            Console.WriteLine(divider);
        }
        Console.WriteLine();
    }

    // calculate sum
    static int CalcSum(int startRow, int startCol, int[,] matrix)
    {
        int sum = 0;
        for (int row = startRow; row < startRow + 2; row++)
            for (int col = startCol; col < startCol + 2; col++)
                sum = sum + matrix[row, col];
        return sum;
    }

    // write result to result.txt
    static void WriteResult(int result)
    {
        using (StreamWriter writer = new StreamWriter(@"..\..\result.txt"))
        {
            writer.WriteLine(result.ToString());
        }
    }
    static void Main(string[] args)
    {
        int[,] matrix;
        try
        {
            matrix = ReadMatrix();
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Cannot file input file");
            return;
        }
        catch (FormatException ex)
        {
            if (ex.InnerException == null)
            {
                Console.WriteLine("Invalid matrix size at line 0");
                return;
            }
            else
            {
                Console.WriteLine("Invalid file format at line {0}", ex.Message);
                return;
            }
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Inssuficient numbers (or wrong format) at line {0}", ex.Message);
            return;
        }

        // calculate sum for every area and compare
        int maxSum = int.MinValue;
        int tmpSum = 0;
        int maxRow = 0;
        int maxCol = 0;
        int matrixSize = matrix.GetLength(0);
        for (int row = 0; row < matrixSize - 1; row++)
            for (int col = 0; col < matrixSize - 1; col++)
            {
                tmpSum = CalcSum(row, col, matrix);
                if (tmpSum > maxSum)
                {
                    maxRow = row;
                    maxCol = col;
                    maxSum = tmpSum;
                }
            }
        Console.WriteLine();
        Console.WriteLine("Maximal sum is {0}", maxSum);
        PrintMatrix(matrix, maxRow, maxCol);
        try
        {
            WriteResult(maxSum);
        }
        catch (IOException)
        {
            Console.WriteLine("Cannot write result to file.");
        }
    }
}

