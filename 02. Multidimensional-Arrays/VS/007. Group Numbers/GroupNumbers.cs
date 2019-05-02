namespace _007._Group_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class GroupNumbers
    {
        static void Main(string[] args)
        {
            var arrayInputNumbers = Console.ReadLine().
                Split(", ", StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();
            var dictDivideGroups = new Dictionary<int, List<int>>();
            dictDivideGroups.Add(0, new List<int>());
            dictDivideGroups.Add(1, new List<int>());
            dictDivideGroups.Add(2, new List<int>());
            foreach (var number in arrayInputNumbers)
            {
                if (number%3==0)
                {
                    dictDivideGroups[0].Add(number);
                }
                else if (number % 3 == 1|| number % 3 == -1)
                {
                    dictDivideGroups[1].Add(number);
                }
                else if (number % 3 == 2|| number % 3 == -2)
                {
                    dictDivideGroups[2].Add(number);
                }

            }
            //Print
            foreach (var kvp in dictDivideGroups)
            {
                if (kvp.Value.Count!=0)
                {
                    Console.WriteLine(string.Join(" ",kvp.Value));
                }
            }
        }
    }
}
