namespace _105._Count_Symbols
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CountSymbols
    {
        static void Main()
        {
            var dictCharAppear = new Dictionary<char, int>();
            var inputLine = Console.ReadLine().ToCharArray();
            //Add in dictionary
            foreach (var charackter in inputLine)
            {
                if (!dictCharAppear.ContainsKey(charackter))
                {
                    dictCharAppear.Add(charackter, 1);
                }
                else
                {
                    dictCharAppear[charackter]++;
                }
            }

            //Print
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var kvp in dictCharAppear.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
