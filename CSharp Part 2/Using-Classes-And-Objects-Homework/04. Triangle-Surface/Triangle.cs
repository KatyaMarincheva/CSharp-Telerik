using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triangle_Surface
{
    class TriangleSides
    {
        // fields
        private object triangle;

        // constructor
        public TriangleSides(decimal sideA, decimal sideB, decimal sideC) //decimal altA, decimal altB, decimal altC, decimal angAB, decimal angAC, decimal angBC)
        {

        }
    }
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
    }
}
