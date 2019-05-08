namespace _001._Count_Same_Values_in_Array
{
using System;
    using System.Collections.Generic;
    using System.Linq;

    class CountSameValuesInArray
    {
        static void Main(string[] args)
        {
            var inputArray = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
            var dictCountValues = new Dictionary<double, int>();

            ///Fill dictionary

            foreach (var input in inputArray)
            {
                if (!dictCountValues.ContainsKey(input))
                {
                    dictCountValues.Add(input, 1);
                }
                else
                {
                    dictCountValues[input]++;
                }
            }

            //Print dict
            foreach (var kvp in dictCountValues)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}
