namespace _108.__Balanced_Parentheses
{
    using System;
    using System.Collections.Generic;
    using System;
    class BalancedParentheses

    {
        static void Main(string[] args)
        {
            Stack<char> stackParentheses = new Stack<char>();
            List<char> openBracked = new List<char>() { '{', '[', '(' };
            List<char> closeBracked = new List<char>() { '}', ']', ')' };
            bool isBalance = true;
            //ReadLine
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                var currentChar = input[i];
                if (openBracked.Contains(currentChar))
                {
                    stackParentheses.Push(currentChar);
                }
                else if (closeBracked.Contains(currentChar))
                {
                    var currentOpenBrackInStack = stackParentheses.Pop();
                    switch (currentOpenBrackInStack)
                    {
                        case '{':
                            if (currentChar != '}')
                            {
                                isBalance = false;
                            }
                            break;
                        case '[':
                            if (currentChar != ']')
                            {
                                isBalance = false;
                            }
                            break;
                        case '(':
                            if (currentChar != ')')
                            {
                                isBalance = false;
                            }
                            break;
                    }
                }
            }
            if (isBalance)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
