using System;
using System.Collections.Generic;
using System.Linq;

namespace _002._Stack_Sum
{
    class StackSum
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var stackCalculator = new Stack<string>(input.Reverse());
            while (stackCalculator.Count>1)
            {
                int firstNumber = int.Parse(stackCalculator.Pop());
                string operatorCalucation = stackCalculator.Pop();
                int secondOperator = int.Parse(stackCalculator.Pop());
                int result=default(int);
                //simple Calculation
                switch (operatorCalucation)
                {
                    case "+":
                        result = firstNumber + secondOperator;
                        break;
                    case "-":
                        result = firstNumber - secondOperator;
                        break;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }
                stackCalculator.Push(result.ToString());
            }
            Console.WriteLine($"{stackCalculator.Peek()}");
        }
    }
}
