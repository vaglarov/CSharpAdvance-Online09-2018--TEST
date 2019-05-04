namespace _106._Target_PracticeI
{
    using System;
    class TargetPractice
    {
        static void Main(string[] args)
        {
            //input
            var arrSizeMatrix = Console.ReadLine().Split();
            var numberRow = int.Parse(arrSizeMatrix[0]);
            var numberCol = int.Parse(arrSizeMatrix[1]);
            var matrix = new char[numberRow][];
            var stringSnakeForMatrix = Console.ReadLine();
            var arrTarget = Console.ReadLine().Split();

            GreateMatrixWhitCurrentSize(matrix, numberCol);
            FillMatrixWithSnakeChar(stringSnakeForMatrix, matrix);

            ShotTarget(matrix, arrTarget);
            ReconstructMatrix(matrix);
            PrintMatriX(matrix);
        }

        private static void ReconstructMatrix(char[][] matrix)
        {

            for (int row = matrix.Length - 1; row >= 0; row--)
            {
                for (int col = matrix[row].Length - 1; col >= 0; col--)
                {
                    //Flip if is ' '
                    if (matrix[row][col] == ' ')
                    {
                        for (int indexRow = row; indexRow >= 0; indexRow--)
                        {
                            if (matrix[indexRow][col] != ' ')
                            {
                                matrix[row][col] = matrix[indexRow][col];
                                matrix[indexRow][col] = ' ';
                                break;
                            }

                        }
                    }
                }
            }
        }

        private static void ShotTarget(char[][] matrix, string[] arrTarget)
        {
            var targetRowCoordinate = int.Parse(arrTarget[0]);
            var targetColCoordinate = int.Parse(arrTarget[1]);
            var targetRAnge = int.Parse(arrTarget[2]);

            //Check Is shot is i target
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    bool isInside = Math.Pow((targetRowCoordinate - row), 2) + Math.Pow((targetColCoordinate - col), 2) <= Math.Pow(targetRAnge, 2);
                    if (isInside)
                    {
                        matrix[row][col] = ' ';
                    }
                }
            }
        }

        private static void PrintMatriX(char[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                Console.WriteLine(string.Join(" ", matrix[row]));
            }
        }

        private static void GreateMatrixWhitCurrentSize(char[][] matrix, int numberCol)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new char[numberCol];
            }
        }

        private static void FillMatrixWithSnakeChar(string stringSnakeForMatrix, char[][] matrix)
        {
            var arrChar = stringSnakeForMatrix.ToCharArray();
            var numerator = 0;
            bool isLeftToRight = true;
            for (int row = matrix.Length - 1; row >= 0; row--)
            {
                if (isLeftToRight)
                {
                    for (int col = matrix[row].Length - 1; col >= 0; col--)
                    {
                        if (numerator == arrChar.Length)
                        {
                            numerator = 0;
                        }
                        matrix[row][col] = arrChar[numerator];
                        numerator++;
                    }
                    isLeftToRight = false;
                }
                else
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        if (numerator == arrChar.Length)
                        {
                            numerator = 0;
                        }
                        matrix[row][col] = arrChar[numerator];
                        numerator++;
                    }
                    isLeftToRight = true;
                }

            }

        }
    }
}
