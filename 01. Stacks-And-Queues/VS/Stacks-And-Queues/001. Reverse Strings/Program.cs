using System;
using System.Collections;
using System.Collections.Generic;

namespace _001._Reverse_Strings
{
    class ReverseStrings
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var firstStach = new Stack<char>();
            for (int index = 0; index < input.Length; index++)
            {
                char characterInput = input[index];
                firstStach.Push(characterInput);
            }
            //string result = string.Empty; 
            //while (firstStach.Count>0)
            //{
            //    result += firstStach.Pop();
            //}

            //Console.WriteLine(result);

            foreach (var item in firstStach)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
