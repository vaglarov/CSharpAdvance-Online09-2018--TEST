namespace _102._Diagonal_Difference
{
using System;
    using System.Linq;

    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int numberSelle = int.Parse(Console.ReadLine());
            int[,] matrix = new int[numberSelle, numberSelle];
            //Fill the matrix with value
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var valueRow = Console.ReadLine().
                    Split().
                    Select(int.Parse).
                    ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = valueRow[col];
                }
            }

            //Calculate difference
            int primaryDiagonal = default(int);
            int secondaryDiagonal = default(int);
            int differenceDiagonals = default(int);
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row==col)
                    {
                        primaryDiagonal += matrix[row, col];
                    }
                    if ((col+row)== numberSelle-1)
                    {
                        secondaryDiagonal += matrix[row, col];
                    }
                }
            }
            differenceDiagonals = Math.Abs(primaryDiagonal - secondaryDiagonal);
            Console.WriteLine(differenceDiagonals);
        }
    }
}
