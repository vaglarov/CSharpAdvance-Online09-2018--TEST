namespace _109.__Simple_Text_Editor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SimpleTextEditor
    {
        static void Main(string[] args)
        {
            Stack<char> stackCharText = new Stack<char>();

            int numberLine = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberLine; i++)
            {
                //ReadCommand
                var commandInput = Console.ReadLine();
                var command = int.Parse(commandInput.Substring(0, 1));
                var argumetn = commandInput.Substring(2);
                switch (command)
                {
                    case 1:
                        for (int argumentIndex = 0; argumentIndex < argumetn.Length; argumentIndex++)
                        {
                            var addChar = argumetn[argumentIndex];
                            stackCharText.Push(addChar);
                        }
                        break;
                    case 2:
                        var numberErasesElement = int.Parse(argumetn);
                        if (numberErasesElement>=stackCharText.Count)
                        {
                            numberErasesElement = stackCharText.Count;
                        }
                        for (int numberErase = 0; numberErase < numberErasesElement; numberErase++)
                        {
                            stackCharText.Pop();
                        }
                        break;
                    case 3:
                        var indexElement = int.Parse(argumetn);
                        var result = stackCharText.Reverse().ToList();
                        Console.WriteLine(result[indexElement-1]);
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Wrong command!!");
                        break;
                }



            }

        }
    }
}
