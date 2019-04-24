using System;
using System.Collections.Generic;

namespace _004._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var stackIndexBrackets = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(') 
                {
                    stackIndexBrackets.Push(i);
                }
                else if (input[i]==')')
                {
                    var startIndex = stackIndexBrackets.Pop();
                    var resultString = input.Substring(startIndex, i - startIndex+1);
                    Console.WriteLine($"{resultString}");
                }

            }

        }
    }
}
