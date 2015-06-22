using System;
using System.Collections.Generic;
using System.Linq;

class Digits
{
    private static int[,] matrix;
    private static int size;

    static void Main()
    {
        size = int.Parse(Console.ReadLine());
        matrix = new int[size, size];

        for (int row = 0; row < size; row++)
        {
            string[] line = Console.ReadLine().Split();
            for (int col = 0; col < size; col++)
            {
                matrix[row, col] = int.Parse(line[col]);
            }
        }

        //start checking
        long sum = 0;
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {

                switch (matrix[row, col])
                {
                    case 1: if (CheckForOne(row, col)) sum += 1;
                        break;
                    case 2: if (CheckForTwo(row, col)) sum += 2;
                        break;
                    case 3: if (CheckForThree(row, col)) sum += 3;
                        break;
                    case 4: if (CheckForFour(row, col)) sum += 4;
                        break;
                    case 5: if (CheckForFive(row, col)) sum += 5;
                        break;
                    case 6: if (CheckForSix(row, col)) sum += 6;
                        break;
                    case 7: if (CheckForSeven(row, col)) sum += 7;
                        break;
                    case 8: if (CheckForEight(matrix, row, col)) sum += 8;
                        break;
                    case 9: if (CheckForNine(row, col)) sum += 9;
                        break;
                }
            }
        }

        Console.WriteLine(sum);
    }

    private static bool CheckForOne(int row, int col)
    {
        return row >= 2 && row < size - 2 && col < size - 2
            && matrix[row - 1, col + 1] == 1 && matrix[row - 2, col + 2] == 1 &&
            matrix[row - 1, col + 2] == 1 && matrix[row, col + 2] == 1 &&
            matrix[row + 1, col + 2] == 1 && matrix[row + 2, col + 2] == 1;
    }

    private static bool CheckForTwo(int row, int col)
    {
        return row >= 1 && row < size - 3 && col < size - 2
            && matrix[row - 1, col + 1] == 2 && matrix[row, col + 2] == 2 &&
            matrix[row + 1, col + 2] == 2 && matrix[row + 2, col + 1] == 2
            && matrix[row + 3, col] == 2 && matrix[row + 3, col + 1] == 2 &&
            matrix[row + 3, col + 2] == 2;
    }

    private static bool CheckForThree(int row, int col)
    {
        return row < size - 4 && col < size - 2 && matrix[row, col + 1] == 3
            && matrix[row, col + 2] == 3 && matrix[row + 1, col + 2] == 3 &&
            matrix[row + 2, col + 2] == 3 && matrix[row + 2, col + 1] == 3 &&
            matrix[row + 3, col + 2] == 3 && matrix[row + 4, col + 2] == 3 &&
            matrix[row + 4, col + 1] == 3 && matrix[row + 4, col] == 3;
    }

    private static bool CheckForFour(int row, int col)
    {
        return row < size - 4 &&
            col < size - 2 && matrix[row + 1, col] == 4 && matrix[row + 2, col] == 4 &&
            matrix[row + 2, col + 1] == 4 && matrix[row + 2, col + 2] == 4 &&
            matrix[row + 1, col + 2] == 4 && matrix[row, col + 2] == 4 &&
            matrix[row + 3, col + 2] == 4 && matrix[row + 4, col + 2] == 4;
    }

    private static bool CheckForFive(int row, int col)
    {
        return row < size - 4 &&
            col < size - 2 && matrix[row, col + 1] == 5 && matrix[row, col + 2] == 5 &&
            matrix[row + 1, col] == 5 && matrix[row + 2, col] == 5 &&
            matrix[row + 2, col + 1] == 5 && matrix[row + 2, col + 2] == 5 &&
            matrix[row + 3, col + 2] == 5 && matrix[row + 4, col + 2] == 5 &&
            matrix[row + 4, col + 1] == 5 && matrix[row + 4, col] == 5;
    }

    private static bool CheckForSix(int row, int col)
    {
        return row < size - 4 &&
            col < size - 2 && matrix[row, col + 1] == 6 && matrix[row, col + 2] == 6 &&
            matrix[row + 1, col] == 6 && matrix[row + 2, col] == 6 &&
            matrix[row + 2, col + 1] == 6 && matrix[row + 2, col + 2] == 6 &&
            matrix[row + 3, col + 2] == 6 && matrix[row + 4, col + 2] == 6 &&
            matrix[row + 4, col + 1] == 6 && matrix[row + 4, col] == 6 &&
            matrix[row + 3, col] == 6;
    }

    private static bool CheckForSeven(int row, int col)
    {
        return row < size - 4 && col < size - 2 &&
            matrix[row, col + 1] == 7 && matrix[row, col + 2] == 7 &&
            matrix[row + 1, col + 2] == 7 && matrix[row + 2, col + 1] == 7 &&
            matrix[row + 3, col + 1] == 7 && matrix[row + 4, col + 1] == 7;
    }

    private static bool CheckForEight(int[,] field, int row, int col)
    {
        return row >= 0 && row < field.GetLength(0) - 4 &&
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
    }

    private static bool CheckForNine(int row, int col)
    {
        return row < size - 4 && col < size - 2
            && matrix[row, col + 1] == 9 && matrix[row, col + 2] == 9 &&
            matrix[row + 1, col] == 9 && matrix[row + 1, col + 2] == 9 &&
            matrix[row + 2, col + 1] == 9 && matrix[row + 2, col + 2] == 9 &&
            matrix[row + 3, col + 2] == 9 && matrix[row + 4, col + 2] == 9 &&
            matrix[row + 4, col + 1] == 9 && matrix[row + 4, col] == 9;
    }
}