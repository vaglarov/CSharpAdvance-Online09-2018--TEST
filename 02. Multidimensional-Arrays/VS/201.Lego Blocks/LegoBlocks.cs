namespace _201.Lego_Blocks
{
using System;
    using System.Linq;

    class LegoBlocks
    {
        static void Main(string[] args)
        {
            var numberRowInArray = int.Parse(Console.ReadLine());
            var matrixFirst = new int[numberRowInArray][];
            var matrixSecond = new int[numberRowInArray][];
            FillMatric(matrixFirst);
            FillMatric(matrixSecond);
            if (IsSizeMach(matrixFirst, matrixSecond))
            {
                PrintNewMatrix(matrixFirst, matrixSecond);
            }
            else
            {
                PrintNumberElement(matrixFirst, matrixSecond);   
            }
        }

        private static void PrintNumberElement(int[][] matrixFirst, int[][] matrixSecond)
        {
            var count = 0;
            for (int rowFirs = 0; rowFirs < matrixFirst.Length; rowFirs++)
            {
                count += matrixFirst[rowFirs].Length;
            }
            for (int rowSec = 0; rowSec < matrixSecond.Length; rowSec++)
            {
                count += matrixSecond[rowSec].Length;
            }
            Console.WriteLine($"The total number of cells is: {count}");
        }

        private static void PrintNewMatrix(int[][] matrixFirst, int[][] matrixSecond)
        {
            var newMatric = new int[matrixFirst.Length][];
            for (int row = 0; row < newMatric.Length; row++)
            {
                var newRow = matrixFirst[row].ToList();
                for (int index = 0; index < matrixSecond[row].Length; index++)
                {
                    newRow.Add(matrixSecond[row][index]);
                }
                newMatric[row] = newRow.ToArray();
            }
            Print(newMatric);
        }

        private static bool IsSizeMach(int[][] matrixFirst, int[][] matrixSecond)
        {
            for (int row = 0; row < matrixFirst.Length-1; row++)
            {
                if (matrixFirst[row].Length+ matrixSecond[row].Length!=
                    matrixFirst[row+1].Length + matrixSecond[row+1].Length)
                {
                    return false;
                }
            }
            return true;
        }

        private static void Print(int[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                Console.WriteLine($"[{string.Join(", ",matrix[row])}]");
            }
        }

        private static void FillMatric(int[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().
                    Split(' ',StringSplitOptions.RemoveEmptyEntries).
                    Select(int.Parse).
                    ToArray();
            }
        }
    }
}
