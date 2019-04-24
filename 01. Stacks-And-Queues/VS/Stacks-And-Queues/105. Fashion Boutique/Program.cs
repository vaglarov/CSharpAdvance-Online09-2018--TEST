using System;
using System.Collections.Generic;
using System.Linq;

namespace _105._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputAllDressInLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Reverse().ToArray();
            var stackBoxx = new Stack<int>();
            var numberDressInBox = int.Parse(Console.ReadLine());
            var boxField = default(int);
            for (int i = 0; i < inputAllDressInLine.Length; i++)
            {
                boxField += inputAllDressInLine[i];
                if (boxField >= numberDressInBox)
                {
                    stackBoxx.Push(numberDressInBox);
                    boxField -= numberDressInBox;

                    if (boxField > 0)
                    {
                        stackBoxx.Push(boxField);
                    boxField = 0;
                    }
                }
            }
            Console.WriteLine(stackBoxx.Count);
        }
    }
}
