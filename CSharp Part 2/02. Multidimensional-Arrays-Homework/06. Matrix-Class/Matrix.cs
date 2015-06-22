using System;

class Matrix
{
    // fields
    private int[,] matrix;

    // constructor
    public Matrix(int rows, int cols)
    {
        this.matrix = new int[rows, cols];
    }

    // properties
    public int Rows
    {
        get
        {
            return this.matrix.GetLength(0);
        }
    }
    public int Columns
    {
        get
        {
            return this.matrix.GetLength(1);
        }
    }

    // Indexer for accessing the matrix content
    public int this[int row, int col]
    {
        get
        {
            return this.matrix[row, col];
        }
        set
        {
            this.matrix[row, col] = value;
        }
    }

    // addition (matrix1 + matrix2)
    public static Matrix operator +(Matrix first, Matrix second)
    {
        Matrix result = new Matrix(first.Rows, first.Columns);
        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Columns; col++)
            {
                result[row, col] = first[row, col] + second[row, col];
            }
        }
        return result;
    }

    // subtraction (matrix1 + matrix2)
    public static Matrix operator -(Matrix first, Matrix second)
    {
        Matrix result = new Matrix(first.Rows, first.Columns);
        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Columns; col++)
            {
                result[row, col] = first[row, col] - second[row, col];
            }
        }
        return result;
    }

    // multiplication (matrix1 + matrix2)
    public static Matrix operator *(Matrix first, Matrix second)
    {
        Matrix result = new Matrix(first.Rows, first.Columns);
        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Columns; col++)
            {
                result[row, col] = first[row, col] * second[col, row];
            }
        }
        return result;
    }

    // Override method ToString() to print matrix elements table view
    public override string ToString()
    {
        string result = null;
        for (int row = 0; row < this.Rows; row++)
        {
            for (int col = 0; col < this.Columns; col++)
            {
                result += matrix[row, col] + " ";
            }
            result += Environment.NewLine;
        }
        return result;
    }
}

