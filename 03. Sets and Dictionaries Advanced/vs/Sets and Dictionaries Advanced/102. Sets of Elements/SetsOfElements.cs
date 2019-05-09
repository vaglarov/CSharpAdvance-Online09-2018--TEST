namespace _102._Sets_of_Elements
{
using System;
    using System.Collections.Generic;
    using System.Linq;

    class SetsOfElements
    {
        static void Main(string[] args)
        {
            var splitInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numbersFirstSet = splitInput[0];
            var numberSecondSet = splitInput[1];

            var hashSetFirstNumber = new HashSet<int>();
            var hashSetSecondNumber = new HashSet<int>();

            //Fill fist HashSet
            for (int i = 0; i < numbersFirstSet; i++)
            {
                var addNumber=int.Parse(Console.ReadLine());
                if (!hashSetFirstNumber.Contains(addNumber))
                {
                    hashSetFirstNumber.Add(addNumber);
                }
            }
            //Fill second HashSet
            for (int index   = 0; index < numberSecondSet; index++)
            {
                var addNumber = int.Parse(Console.ReadLine());
                if (!hashSetSecondNumber.Contains(addNumber))
                {
                    hashSetSecondNumber.Add(addNumber);
                }
            }


            //Intersect hashSet

            var result = hashSetFirstNumber.Intersect(hashSetSecondNumber).ToList();

            //Print result
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
