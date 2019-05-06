namespace _202
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class RadioactiveBunnies
    {
        static int playerRow;
        static int playerCol;
        static char[][] jaggedArray;
        static bool isWin;
        static bool isDead;
        static void Main(string[] args)
        {
            int[] sizeMatrix = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = sizeMatrix[0];
            int cols = sizeMatrix[1];
            jaggedArray = new char[rows][];
            GetJaggedarray(cols);

            string directionsCommand = Console.ReadLine();

            MovePlayer(directionsCommand);

            PrintJaggedArray();
            if (isWin)
            {
                Console.WriteLine($"won: {playerRow} {playerCol}");
            }
            else if (isDead)
            {
                Console.WriteLine($"dead: {playerRow} {playerCol}");
            }
        }

        private static void MovePlayer(string directionsCommand)
        {
            for (int index = 0; index < directionsCommand.Length; index++)
            {
                var charCommand = directionsCommand[index];
                switch (charCommand)
                {
                    case 'L':
                        Move(0, -1);
                        SpreadBunny();
                        if (isDead || isWin)
                        {
                            return;
                        }
                        break;
                    case 'R':
                        Move(0, +1);
                        SpreadBunny();
                        if (isDead || isWin)
                        {
                            return;
                        }
                        break;
                    case 'U':
                        Move(-1, 0);
                        SpreadBunny();
                        if (isDead || isWin)
                        {
                            return;
                        }
                        break;
                    case 'D':
                        Move(+1, 0);
                        SpreadBunny();
                        if (isDead || isWin)
                        {
                            return;
                        }
                        break;
                    default:
                        Console.WriteLine("Error input!!!");
                        break;
                }
            }
        }

        private static void SpreadBunny()
        {
            var queueBunnyCoor = new Queue<int[]>();
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    if (jaggedArray[row][col] == 'B')
                    {
                        queueBunnyCoor.Enqueue(new int[] { row, col });
                    }
                }
            }

            while (queueBunnyCoor.Count > 0)
            {
                var bunnySpread = queueBunnyCoor.Dequeue();
                var currentBunnyRow = bunnySpread[0];
                var currentBunnyCol = bunnySpread[1];

                if (IsInside(currentBunnyRow - 1, currentBunnyCol))
                {
                    if (IsPlayer(currentBunnyRow - 1, currentBunnyCol))
                    {
                        isDead = true;
                    }
                    jaggedArray[currentBunnyRow - 1][currentBunnyCol] = 'B';
                }
                if (IsInside(currentBunnyRow + 1, currentBunnyCol))
                {
                    if (IsPlayer(currentBunnyRow + 1, currentBunnyCol))
                    {
                        isDead = true;
                    }
                    jaggedArray[currentBunnyRow + 1][currentBunnyCol] = 'B';
                }
                if (IsInside(currentBunnyRow, currentBunnyCol - 1))
                {
                    if (IsPlayer(currentBunnyRow, currentBunnyCol - 1))
                    {
                        isDead = true;
                    }
                    jaggedArray[currentBunnyRow][currentBunnyCol - 1] = 'B';
                }
                if (IsInside(currentBunnyRow, currentBunnyCol + 1))
                {
                    if (IsPlayer(currentBunnyRow, currentBunnyCol + 1))
                    {
                        isDead = true;
                    }
                    jaggedArray[currentBunnyRow][currentBunnyCol + 1] = 'B';
                }

            }
        }

        private static bool IsPlayer(int row, int col)
        {
            if (jaggedArray[row][col] == 'P')
            {

                return true;
            }
            return false;
        }

        private static void Move(int row, int col)
        {
            int newCoorPlayerRow = playerRow + row;
            int newCoorPlayerCol = playerCol + col;
            if (!IsInside(newCoorPlayerRow, newCoorPlayerCol))
            {
                jaggedArray[playerRow][playerCol] = '.';
                isWin = true;
            }
            else if (IsBunny(newCoorPlayerRow, newCoorPlayerCol))
            {
                isDead = true;
            }
            else
            {
                jaggedArray[playerRow][playerCol] = '.';
                jaggedArray[newCoorPlayerRow][newCoorPlayerCol] = 'P';
            }
            playerRow = newCoorPlayerRow;
            playerCol = newCoorPlayerCol;
        }

        private static bool IsBunny(int newRow, int newCol)
        {
            if (jaggedArray[newRow][newCol] == 'B')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsInside(int newRow, int newCol)
        {
            if (newRow >= 0 &&
                newRow < jaggedArray.Length &&
                newCol >= 0 &&
                newCol < jaggedArray[jaggedArray.Length - 1].Length
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void PrintJaggedArray()
        {
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                Console.WriteLine(string.Join("", jaggedArray[row]));
            }
        }

        private static void GetJaggedarray(int cols)
        {
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                var input = Console.ReadLine().ToCharArray();
                jaggedArray[row] = new char[cols];
                for (int col = 0; col < input.Length; col++)
                {
                    jaggedArray[row][col] = input[col];
                    if (jaggedArray[row][col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
        }
    }
}
