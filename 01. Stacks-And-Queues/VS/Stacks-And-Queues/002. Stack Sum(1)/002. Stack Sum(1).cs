using System;
using System.Collections.Generic;
using System.Linq;

namespace _002._Stack_Sum_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var stackNumbers = new Stack<int>();
            foreach (var number in input)
            {
                stackNumbers.Push(int.Parse(number));
            }
            string nextInput = string.Empty;
            while ((nextInput = Console.ReadLine().ToLower()) != "end")
            {
                var command = nextInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                switch (command[0].ToLower())
                {
                    case "remove":
                        int numberOfPop = int.Parse(command[1]);
                        if (stackNumbers.Count <numberOfPop)
                        {
                            break;
                        }
                        for (int i = 0; i < numberOfPop; i++)
                        {
                            stackNumbers.Pop();
                           
                        }
                        break;
                    case "add":
                        for (int i = 1; i < command.Length; i++)
                        {
                            stackNumbers.Push(int.Parse(command[i]));
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }
            }
            //Print Result
            Console.WriteLine($"Sum: {stackNumbers.Sum()}");
        }
    }
}
