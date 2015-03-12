﻿using System;
// C# Part 2 - 2013/2014 @ 24 Jan 2014 - Evening
// 3. Digits
class Digits
{
    private static int size;
    static void Main()
    {
        size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];
        for (int row = 0; row < size; row++)
        {
            string currLine = Console.ReadLine().Replace(" ", "");
            for (int col = 0; col < size; col++)
            {
                matrix[row, col] = currLine[col] - '0';
            }
        }
        Console.WriteLine(SearchForPatterns(matrix));
    }
    private static int SearchForPatterns(int[,] matrix)
    {
        int result = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                switch (matrix[row, col])
                {
                    case 1: result += CheckForOne(matrix, row, col); break;
                    case 2: result += CheckForTwo(matrix, row, col); break;
                    case 3: result += CheckForThree(matrix, row, col); break;
                    case 4: result += CheckForFour(matrix, row, col); break;
                    case 5: result += CheckForFive(matrix, row, col); break;
                    case 6: result += CheckForSix(matrix, row, col); break;
                    case 7: result += CheckForSeven(matrix, row, col); break;
                    case 8: result += CheckForEight(matrix, row, col); break;
                    case 9: result += CheckForNine(matrix, row, col); break;
                }
            }
        }
        return result;
    }
    private static int CheckForOne(int[,] matrix, int row, int col)
    {
        bool containsOnePattern = row >= 2 && row < size - 2 && col < size - 2
            && matrix[row - 1, col + 1] == 1 && matrix[row - 2, col + 2] == 1 &&
            matrix[row - 1, col + 2] == 1 && matrix[row, col + 2] == 1 &&
            matrix[row + 1, col + 2] == 1 && matrix[row + 2, col + 2] == 1;
        return (containsOnePattern) ? 1 : 0;
    }
    private static int CheckForTwo(int[,] matrix, int row, int col)
    {
        bool containsTwoPattern = row >= 1 && row < size - 3 && col < size - 2
            && matrix[row - 1, col + 1] == 2 && matrix[row, col + 2] == 2 &&
            matrix[row + 1, col + 2] == 2 && matrix[row + 2, col + 1] == 2
            && matrix[row + 3, col] == 2 && matrix[row + 3, col + 1] == 2 &&
            matrix[row + 3, col + 2] == 2;
        return (containsTwoPattern) ? 2 : 0;
    }
    private static int CheckForThree(int[,] matrix, int row, int col)
    {
        bool containsThreePattern = row < size - 4 && col < size - 2 && matrix[row, col + 1] == 3
            && matrix[row, col + 2] == 3 && matrix[row + 1, col + 2] == 3 &&
            matrix[row + 2, col + 2] == 3 && matrix[row + 2, col + 1] == 3 &&
            matrix[row + 3, col + 2] == 3 && matrix[row + 4, col + 2] == 3 &&
            matrix[row + 4, col + 1] == 3 && matrix[row + 4, col] == 3;
        return (containsThreePattern) ? 3 : 0;
    }
    private static int CheckForFour(int[,] matrix, int row, int col)
    {
        bool containsFourPattern = row < size - 4 &&
            col < size - 2 && matrix[row + 1, col] == 4 && matrix[row + 2, col] == 4 &&
            matrix[row + 2, col + 1] == 4 && matrix[row + 2, col + 2] == 4 &&
            matrix[row + 1, col + 2] == 4 && matrix[row, col + 2] == 4 &&
            matrix[row + 3, col + 2] == 4 && matrix[row + 4, col + 2] == 4;
        return (containsFourPattern) ? 4 : 0;
    }
    private static int CheckForFive(int[,] matrix, int row, int col)
    {
        bool containsFivePattern = row < size - 4 &&
            col < size - 2 && matrix[row, col + 1] == 5 && matrix[row, col + 2] == 5 &&
            matrix[row + 1, col] == 5 && matrix[row + 2, col] == 5 &&
            matrix[row + 2, col + 1] == 5 && matrix[row + 2, col + 2] == 5 &&
            matrix[row + 3, col + 2] == 5 && matrix[row + 4, col + 2] == 5 &&
            matrix[row + 4, col + 1] == 5 && matrix[row + 4, col] == 5;
        return (containsFivePattern) ? 5 : 0;
    }
    private static int CheckForSix(int[,] matrix, int row, int col)
    {
        bool containsSixPattern = row < size - 4 &&
            col < size - 2 && matrix[row, col + 1] == 6 && matrix[row, col + 2] == 6 &&
            matrix[row + 1, col] == 6 && matrix[row + 2, col] == 6 &&
            matrix[row + 2, col + 1] == 6 && matrix[row + 2, col + 2] == 6 &&
            matrix[row + 3, col + 2] == 6 && matrix[row + 4, col + 2] == 6 &&
            matrix[row + 4, col + 1] == 6 && matrix[row + 4, col] == 6 &&
            matrix[row + 3, col] == 6;
        return containsSixPattern ? 6 : 0;
    }
    private static int CheckForSeven(int[,] matrix, int row, int col)
    {
        bool containsSevenPattern = row < size - 4 && col < size - 2 &&
            matrix[row, col + 1] == 7 && matrix[row, col + 2] == 7 &&
            matrix[row + 1, col + 2] == 7 && matrix[row + 2, col + 1] == 7 &&
            matrix[row + 3, col + 1] == 7 && matrix[row + 4, col + 1] == 7;
        return containsSevenPattern ? 7 : 0;
    }
    private static int CheckForEight(int[,] field, int row, int col)
    {
        bool containsEightPattern = row >= 0 && row < field.GetLength(0) - 4 &&
        col >= 0 && col < field.GetLength(1) - 2 &&
        field[row, col] == 8 &&
        field[row, col + 1] == 8 &&
        field[row, col + 2] == 8 &&
        field[row + 1, col + 2] == 8 &&
        field[row + 2, col + 1] == 8 &&
        field[row + 3, col] == 8 &&
        field[row + 4, col] == 8 &&
        field[row + 4, col + 1] == 8 &&
        field[row + 4, col + 2] == 8 &&
        field[row + 3, col + 2] == 8 &&
        field[row + 1, col] == 8;
        return containsEightPattern ? 8 : 0;
    }
    private static int CheckForNine(int[,] matrix, int row, int col)
    {
        bool containsNinePattern = row < size - 4 && col < size - 2
            && matrix[row, col + 1] == 9 && matrix[row, col + 2] == 9 &&
            matrix[row + 1, col] == 9 && matrix[row + 1, col + 2] == 9 &&
            matrix[row + 2, col + 1] == 9 && matrix[row + 2, col + 2] == 9 &&
            matrix[row + 3, col + 2] == 9 && matrix[row + 4, col + 2] == 9 &&
            matrix[row + 4, col + 1] == 9 && matrix[row + 4, col] == 9;
        return containsNinePattern ? 9 : 0;
    }
}