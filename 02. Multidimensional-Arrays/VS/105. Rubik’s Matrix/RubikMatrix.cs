
namespace _105._Rubik_s_Matrix
{
    using System;
    using System.Linq;

    class RubikMatrix
    {
        static void Main(string[] args)
        {
            var arrSizeMatrix = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToArray();
            var numberRow = arrSizeMatrix[0];
            var numberCol = arrSizeMatrix[1];
            var matrix = new int[numberRow][];
            FillMatrix(matrix, numberCol);

            int commandsCount=int.Parse(Console.ReadLine());
            for (int indez = 0; indez < commandsCount; indez++)
            {
                var command = Console.ReadLine().Split();
                var rowColIndex = int.Parse(command[0]);
                var edinting = command[1];
                var numberEditind = int.Parse(command[0]);
                switch (edinting.ToLower())
                {
                    case "right":
                        RightElement(matrix, rowColIndex, numberEditind % matrix[matrix.Length - 1].Length);
                        break;
                    case "left":
                        LeftElement(matrix, rowColIndex, numberEditind % matrix[matrix.Length - 1].Length);
                        break;
                    case "up":
                        UpElement(matrix, rowColIndex, numberEditind%matrix.Length);
                        break;
                    case "down":
                        DownElement(matrix, rowColIndex, numberEditind % matrix.Length);
                        break;
                    default:
                        Console.WriteLine("Don't support this moveind!");
                        break;
                }
            }
                CheckIsMatrixOrdered(matrix);
        }

        private static void CheckIsMatrixOrdered(int[][] matrix)
        {
            var counter = 1;
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col]==counter)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        SwapElements(matrix, row, col, counter);
                    }
                    counter++;
                }
            }
        }

        private static void SwapElements(int[][] matrix, int rowLast, int colLast, int counter)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == counter)
                    {
                        matrix[row][col] = matrix[rowLast][colLast];
                        matrix[rowLast][colLast] = counter;
                        Console.WriteLine($"Swap ({rowLast}, {colLast}) with ({row}, {col})");
                        return;
                    }
                }
            }
        }

        private static void RightElement(int[][] matrix, int row, int move)
        {
            for (int index   = 0; index < move; index++)
            {
                var lastElement = matrix[row][matrix[row].Length - 1];
                for (int col = matrix[row].Length - 1; col > 0; col--)
                {
                    matrix[row][col] = matrix[row][col - 1];
                }
                matrix[row][0] = lastElement;
            }
        }

        private static void LeftElement(int[][] matrix, int row, int move)
        {
            for (int index = 0; index < move; index++)
            {
                var firstElement = matrix[row][0];
                for (int col = 0; col < matrix[row].Length-1; col++)
                {
                    matrix[row][col] = matrix[row][col + 1];
                }
                matrix[row][matrix[row].Length - 1] = firstElement;
            }
        }

        private static void DownElement(int[][] matrix, int col, int move)
        {
            for (int i = 0; i < move; i++)
            {
                var lastElement = matrix[matrix.Length - 1][col];
                for (int row = matrix.Length-1; row > 0; row--)
                {
                    matrix[row][col] = matrix[row - 1][col];
                }
                matrix[0][col] = lastElement;
            }
        }

        private static void UpElement(int[][] matrix, int col, int move)
        {
            for (int i = 0; i < move; i++)
            {
                var firstElement = matrix[0][col];
                for (int row = 0; row < matrix.Length-1; row++)
                {
                    matrix[row][col] = matrix[row+1][col];
                }
                matrix[matrix.Length - 1][col] = firstElement;
            }
        }

        private static void PrintMatrix(int[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                Console.WriteLine(string.Join(" ",matrix[row]));
            }
        }

        private static void FillMatrix(int[][] matrix, int numberCol)
        {
            var numerator = 1;
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new int[numberCol];
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = numerator;
                    numerator++;
                }
            }
        }
    }
}
