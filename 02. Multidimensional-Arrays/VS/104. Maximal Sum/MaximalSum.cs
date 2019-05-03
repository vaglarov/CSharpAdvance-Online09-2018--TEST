namespace _104._Maximal_Sum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MaximalSum
    {
        static void Main(string[] args)
        {
            var arrMatrixData = Console.ReadLine().
               Split().
               Select(int.Parse).
               ToArray();
            var numberRow = arrMatrixData[0];
            var numberCol = arrMatrixData[1];
            if (numberRow>3||numberRow>3)
            {
                int[,] matrix = new int[numberRow, numberCol];

                // Fill matrix with elements
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    var inputRow = Console.ReadLine().
                    Split().
                    Select(int.Parse).
                    ToArray();

                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = inputRow[col];
                    }
                }

                //Found matrix 3x3 with biggest sum elemnt
                var maxSumElements = Int64.MinValue;
                var startIndexRow = default(Int32);
                var startIndexCol = default(Int32);
                for (int row = 0; row < matrix.GetLength(0) - 2; row++)
                {
                    for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                    {
                        var currentSumElements = 0;
                        for (int currentRow = row; currentRow <= row + 2; currentRow++)
                        {
                            for (int currentCol = col; currentCol <= col + 2; currentCol++)
                            {
                                currentSumElements += matrix[currentRow, currentCol];
                            }
                        }
                        if (maxSumElements < currentSumElements)
                        {
                            maxSumElements = currentSumElements;
                            startIndexRow = row;
                            startIndexCol = col;
                        }
                    }
                }

                //Print max sum and matric
                Console.WriteLine($"Sum = {maxSumElements}");

                for (int rowMiniMatrix = startIndexRow; rowMiniMatrix < startIndexRow + 3; rowMiniMatrix++)
                {
                    for (int colMiniMatrix = startIndexCol; colMiniMatrix < startIndexCol + 3; colMiniMatrix++)
                    {
                        if (colMiniMatrix != startIndexCol + 2)
                        {
                            Console.Write($"{matrix[rowMiniMatrix, colMiniMatrix]} ");
                        }
                        else
                        {
                            Console.Write(matrix[rowMiniMatrix, colMiniMatrix]);
                        }
                    }
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine("Incorect input!!!");
            }
            
        }
    }
}
