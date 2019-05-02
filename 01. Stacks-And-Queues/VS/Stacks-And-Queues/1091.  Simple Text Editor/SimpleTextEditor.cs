namespace _1091.__Simple_Text_Editor
{
    using System;
    using System.Collections.Generic;

    class SimpleTextEditor
    {
        static void Main(string[] args)
        {
            int numberLineInput = int.Parse(Console.ReadLine());
            Stack<string> stackWords = new Stack<string>();
            for (int i = 0; i < numberLineInput; i++)
            {
                //ReadCommand
                var commandInput = Console.ReadLine();
                var command = int.Parse(commandInput.Substring(0, 1));
                var argumetn = string.Empty;
                if (commandInput.Length > 1)
                {
                    argumetn = commandInput.Substring(2);
                }
                switch (command)
                {
                    case 1:
                        var word = string.Empty;
                        if (stackWords.Count == 0)
                        {
                            word = argumetn;
                            stackWords.Push(word);
                        }
                        else
                        {
                            word = stackWords.Peek();
                            word += argumetn;
                            stackWords.Push(word);
                        }
                        break;
                    case 2:
                        var numberErasesElement = int.Parse(argumetn);
                        word = stackWords.Peek();
                        if (numberErasesElement>word.Length)
                        {
                            numberErasesElement = word.Length;
                        }
                        word = word.Substring(0, (word.Length - (numberErasesElement)));
                        stackWords.Push(word);
                        break;
                    case 3:
                        var numberIndex = int.Parse(argumetn) - 1;
                        word = stackWords.Peek();
                        if (numberIndex > word.Length - 1)
                        {
                            Console.WriteLine("Index out of rannge! Please try again");
                        }
                        else
                        {
                            for (int index = 0; index < word.Length; index++)
                            {
                                if (index == numberIndex)
                                {
                                    Console.WriteLine(word[index]);
                                    break;
                                }
                            }
                        }
                        break;
                    case 4:
                        stackWords.Pop();
                        break;
                    default:
                        Console.WriteLine("Wrong command!!");
                        break;
                }
            }
        }
    }
}
