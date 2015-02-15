// 1. Fill the matrix

/* Write a program that fills and prints a matrix of size (n, n) as shown below:

Example for n=4:
a) 	b) 	c) 	d)*
1 	5 	9 	13
2 	6 	10 	14
3 	7 	11 	15
4 	8 	12 	16
	
1 	8 	9 	16
2 	7 	10 	15
3 	6 	11 	14
4 	5 	12 	13
	
7 	11 	14 	16
4 	8 	12 	15
2 	5 	9 	13
1 	3 	6 	10
	
1 	12 	11 	10
2 	13 	16 	9
3 	14 	15 	8
4 	5 	6 	7
 */

using System;
class FourMatrices
{
    static void Main()
    {
        Console.Write("Enter size of matrix N: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        /* The counter will be filling the matrices, as the numbers in them are to be consecutive */
        int counter;

        // solution "A"

        Console.WriteLine("\nSolution A:");
        counter = 1;
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                matrix[col, row] = counter;
                counter++;
            }
        }

        // calling the PrintMatrix method
        PrintMatrix(n, matrix);

        // solution "B"
        Console.WriteLine("Solution B:");
        counter = 1;
        for (int row = 0; row < n; row++)
            for (int col = 0; col < n; col++)
            {
                if (row % 2 == 0)
                {
                    matrix[col, row] = counter;
                }
                
                // the odd columns will be printed backwards
                else
                {
                    matrix[n - col - 1, row] = counter;
                }

                counter++;
            }

        PrintMatrix(n, matrix);

        // solution "C"
        Console.WriteLine("Solution C:");
        counter = 1;
        for (int i = n - 1; i >= 0; i--)
        {
            int row = i; // rows printed backwards
            int col = 0; // columns - forward
            do
            {
                matrix[row, col] = counter;
                col++;
                row++;
                counter++;
            } while (row < n);
        }
        for (int i = 1; i < n; i++)
        {
            // both rows and columns printed forward
            int col = i;
            int row = 0;
            do
            {
                matrix[row, col] = counter;
                col++;
                row++;
                counter++;
            } while (col < n);
        }
        PrintMatrix(n, matrix);

        // solution "D"
        Console.WriteLine("Solution D:");
        int leftColumn = 0; // First unfilled row
        int rightColumn = n - 1; // Last unfilled row
        int upperRow = 0; // Left unfilled column
        int bottomRow = n - 1; // Right unfilled column
        int count = 1; // from 1 to N*N
        do
        {
            for (int i = upperRow; i <= bottomRow; i++) // filling the first available column
            {
                matrix[i, leftColumn] = count;
                count++;
            }
            leftColumn++; // we go to the next column

            for (int i = leftColumn; i <= rightColumn; i++) // filling the bottom row
            {
                matrix[bottomRow, i] = count;
                count++;
            }

            bottomRow--; // we go one row up
            for (int i = bottomRow; i >= upperRow; i--) // filling the rightmost column
            {
                matrix[i, rightColumn] = count;
                count++;
            }
            rightColumn--; // we go one column to the left
            for (int i = rightColumn; i >= leftColumn; i--) // filling top available column
            {
                matrix[upperRow, i] = count;
                count++;
            }
            upperRow++; // one row down again
        } while (count <= n * n); // and continuing the spiral until count = n*n

        PrintMatrix(n, matrix);
    }


    private static void PrintMatrix(int n, int[,] matrix)
    {

        for (int rows = 0; rows < n; rows++)
        {
            for (int cols = 0; cols < n; cols++)
            {
                // changed places of rows and columns, so that we can get the columns printed one by one
                Console.Write("{0,3}", matrix[rows, cols]); 
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

