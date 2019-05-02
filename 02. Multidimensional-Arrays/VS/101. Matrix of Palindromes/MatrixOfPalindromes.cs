namespace _101._Matrix_of_Palindromes
{
using System;
    class MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            var inputRowAndCol = Console.ReadLine().Split();
            var rowMatrix    = int.Parse(inputRowAndCol[0]);
            var colMatrix = int.Parse(inputRowAndCol[1]);
            char[] alphabet= "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            string[,] matrixString = new string[rowMatrix,colMatrix];

            //Fill Matrix with element
            for (int row = 0; row < matrixString.GetLength(0); row++)
            {
                for (int col = 0; col <matrixString.GetLength(1); col++)
                {
                    var firtChar = alphabet[row];
                    var secondChar = alphabet[col + row];
                    var third = firtChar;
                    var elemetn = firtChar.ToString() + secondChar.ToString() + third.ToString();
                    matrixString[row, col] = elemetn;
                }
            }

            //Print Matrix
            for (int row = 0; row < matrixString.GetLength(0); row++)
            {
                for (int col = 0; col < matrixString.GetLength(1); col++)
                {
                    if (col==matrixString.GetLength(1)-1)
                    {
                        Console.Write(matrixString[row,col]);
                    }
                    else
                    {
                        Console.Write($"{matrixString[row,col]} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
