namespace _103._PeriodicTable
{
using System;
    using System.Collections.Generic;
    using System.Linq;

    class PeriodicTable
    {
        static void Main(string[] args)
        {
            var hashSetChemicalEl = new HashSet<string>();
            var numberLineInput = int.Parse(Console.ReadLine());
            //Fill hashSet
            for (int i = 0; i < numberLineInput; i++)
            {
                var splitLine = Console.ReadLine().Split();
                for (int indexSplit = 0; indexSplit < splitLine.Length; indexSplit++)
                {
                    if (!hashSetChemicalEl.Contains(splitLine[indexSplit]))
                    {
                        hashSetChemicalEl.Add(splitLine[indexSplit]);
                    }
                }
            }

            //Print result
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(string.Join(" ",hashSetChemicalEl.OrderBy(x=>x)));
        }
    }
}
