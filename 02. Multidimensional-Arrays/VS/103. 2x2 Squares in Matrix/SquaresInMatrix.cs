namespace _103._2x2_Squares_in_Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SquaresInMatrix
    {
        static void Main(string[] args)
        {
            var arrMatrixData = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToArray();
            var numberRow = arrMatrixData[0];
            var numberCol = arrMatrixData[1];
            int[,] matrix = new int[numberRow, numberCol];

            //Fill matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var inputRow = Console.ReadLine().
                Split().
                Select(char.Parse).
                ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputRow[col];
                }
            }

            //Check for Matrix 2x2 with equal elements and safe startElement in list
            var indexFirstElementMatrix = new List<int[,]>();
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row + 1, col] &&
                        matrix[row+1, col] == matrix[row +1, col+1] &&
                        matrix[row, col + 1] == matrix[row + 1, col + 1])
                    {
                        var startIndexMinMatrix = new int[row, col];
                        indexFirstElementMatrix.Add(startIndexMinMatrix);
                    }
                }
            }

            //Print number matrix with equal elements
            Console.WriteLine(indexFirstElementMatrix.Count);
        }
    }
}
