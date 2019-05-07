namespace _203.Crossfire
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Crossfire
    {
        public static List<List<int>> matrixList;
        static void Main(string[] args)
        {
            var inputMatrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var inputRow = inputMatrixSize[0];
            var inputCol = inputMatrixSize[1];
            FillMatrixValue(inputRow, inputCol);
            EditMatrix();
            PintMatrix();
        }

        private static void EditMatrix()
        {
            var input = string.Empty;
            while ((input = Console.ReadLine()) != "Nuke it from orbit")
            {
                var inputSplit = input.Split().Select(int.Parse).ToArray();
                var targetRow = inputSplit[0];
                var targetCol = inputSplit[1];
                var targetRange = inputSplit[2];
                //if is inside matrix
                if (targetRow >= 0 &&
                    targetRow < matrixList.Count &&
                    targetCol >= 0 &&
                    targetCol < matrixList[targetRow].Count)
                {
                    //Mark all row with 0
                    var startIndexRowRange = targetRow - targetRange;
                    if (targetRange - targetRow < 0)
                    {
                        startIndexRowRange = 0;
                    }
                    var endIndexRowRange = targetRange + targetRange;
                    if (targetRow + targetRange >= matrixList.Count - 1)
                    {
                        endIndexRowRange = matrixList.Count - 1;
                    }
                    for (int row = startIndexRowRange; row <= endIndexRowRange; row++)
                    {
                        matrixList[row][targetCol] = 0;
                    }
                    //Mark all col with 0
                    var startIndexColRange = targetCol - targetRange;
                    if (targetRange - targetCol < 0)
                    {
                        startIndexRowRange = 0;
                    }
                    var endIndexColRange = targetCol + targetRange;
                    if (targetCol + targetRange >= matrixList[targetRow].Count - 1)
                    {
                        endIndexColRange = matrixList[targetRow].Count - 1;
                    }
                    for (int col = startIndexColRange; col <= endIndexColRange; col++)
                    {
                        matrixList[targetRow][col] = 0;
                    }
                }
            }
                    for (int row = 0; row < matrixList.Count; row++)
                    {
                        matrixList[row].RemoveAll(x => x == 0);
                        if (matrixList[row].Count==0)
                        {
                            matrixList.RemoveAt(row);
                            row--;
                        }
                    }
            return;
        }

        private static void PintMatrix()
        {
            for (int row = 0; row < matrixList.Count; row++)
            {
                Console.WriteLine(string.Join("\t", matrixList[row]));
            }
        }

        private static void FillMatrixValue(int rowSize, int colSize)
        {
            var numerator = 1;
            matrixList = new List<List<int>>();
            for (int row = 0; row < rowSize; row++)
            {
                matrixList.Add(new List<int>());
                for (int col = 0; col < colSize; col++)
                {
                    matrixList[row].Add(numerator);
                    numerator++;
                }
            }
        }
    }
}
