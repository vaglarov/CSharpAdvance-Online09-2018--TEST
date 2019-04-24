using System;
using System.Collections.Generic;
using System.Linq;

namespace _103._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLineInput = int.Parse(Console.ReadLine());
            var stackElements = new Stack<int>();
            if (numberLineInput > 0 && numberLineInput < 106)
            {

                for (int i = 0; i < numberLineInput; i++)
                {
                    var line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    switch (line[0])
                    {
                        //Push Elements in Stack
                        case 1:
                            var pushedElemt = line[1];
                            if (pushedElemt > 0 && pushedElemt < 110)
                            {
                                stackElements.Push(pushedElemt);
                            }
                            break;
                            //Pop Elements from Stack
                        case 2:
                            if (stackElements.Count > 0)
                            {
                                stackElements.Pop();
                            }
                            break;
                            // Print Max element
                        case 3:
                            Console.WriteLine($"{stackElements.Max()}");
                            break;
                            // Print Min element
                        case 4:
                            Console.WriteLine($"{stackElements.Min()}");
                            break;
                        default:
                            Console.WriteLine("Wrong input");
                            break;
                    }
                }
                Console.WriteLine($"{string.Join(", ", stackElements)}");
            }
        }
    }
}
