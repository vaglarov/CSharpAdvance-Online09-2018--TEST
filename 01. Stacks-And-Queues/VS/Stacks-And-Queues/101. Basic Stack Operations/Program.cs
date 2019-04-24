using System;
using System.Collections.Generic;
using System.Linq;

namespace _101._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLineInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int numberElementsPushInStack = int.Parse(firstLineInput[0]);
            int numberElementsPopFromStack = int.Parse(firstLineInput[1]);
            int numberContains = int.Parse(firstLineInput[2]);
            var secondLineInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var stackNumbers = new Stack<int>();
            //Push in stack
            for (int i = 0; i < numberElementsPushInStack; i++)
            {
                stackNumbers.Push(secondLineInput[i]);
            }
            //Pop out from stack
            if (numberElementsPopFromStack <= stackNumbers.Count)
            {
                for (int i = 0; i < numberElementsPopFromStack; i++)
                {
                    stackNumbers.Pop();
                }
            }
            //Print
            if (stackNumbers.Count==0)
            {
                Console.WriteLine("0");
            }
            else if (stackNumbers.Contains(numberContains))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine($"{stackNumbers.Min()}");
            }
        }
    }
}
