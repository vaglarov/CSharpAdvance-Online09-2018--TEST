using System;
using System.Linq;

namespace _002._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLineRowAndCol = Console.ReadLine().
                Split(", ", StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();
            var rowMatrix = inputLineRowAndCol[0];
            var colMatrix = inputLineRowAndCol[1];
            int[,] matrix = new int[rowMatrix,colMatrix];
            // Fill Matrix

            for (int row = 0; row <matrix.GetLength(0) ; row++)
            {
                var colElements = Console.ReadLine().
                    Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries).
                    Select(int.Parse).
                    ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            // Sum ColElement and Print

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                var sumColElements = default(int);
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sumColElements += matrix[row, col];
                }
                Console.WriteLine(sumColElements);
            }


        }
    }
}
