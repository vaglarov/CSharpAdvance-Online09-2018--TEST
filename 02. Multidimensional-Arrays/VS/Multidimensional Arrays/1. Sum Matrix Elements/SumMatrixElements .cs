 using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberRowAndCol = Console.ReadLine().
                Split(", ", StringSplitOptions.RemoveEmptyEntries);
            int rowMatrix = int.Parse(numberRowAndCol[0]);
            int colMatrix = int.Parse(numberRowAndCol[1]);
            //Fill Matrix
            int[,] matrix = new int[rowMatrix,colMatrix];
            for (int row = 0; row < matrix.GetLength(0); row++)
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
            int sumElemetnt = default(int);
            foreach (var element in matrix)
            {
                sumElemetnt += element;
            }
            // Print result

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sumElemetnt);
        }
    }
}
