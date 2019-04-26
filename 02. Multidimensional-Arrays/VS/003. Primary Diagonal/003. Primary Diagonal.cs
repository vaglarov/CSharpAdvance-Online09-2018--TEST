using System;
using System.Linq;

namespace _003._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberRowAndCol = int.Parse(Console.ReadLine());
            int[,] matrix = new int[numberRowAndCol, numberRowAndCol];
            // Fill Matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var colElements = Console.ReadLine().
                    Split(" ", StringSplitOptions.RemoveEmptyEntries).
                    Select(int.Parse).
                    ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            var sumLeftDiagonal = default(int);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sumLeftDiagonal += matrix[i, i];
            }
            Console.WriteLine(sumLeftDiagonal);
        }
    }
}
