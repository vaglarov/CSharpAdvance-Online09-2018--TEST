namespace _104._Even_Times
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class EvenTimes
    {
        static void Main(string[] args)
        {
            var dictAppearence = new Dictionary<int, int>();
            var numberLineInput = int.Parse(Console.ReadLine());

            //Fill Dictionary
            for (int i = 0; i < numberLineInput; i++)
            {
                var newNumber = int.Parse(Console.ReadLine());
                if (!dictAppearence.ContainsKey(newNumber))
                {
                    dictAppearence.Add(newNumber, 1);
                }
                else
                {
                dictAppearence[newNumber]++;
                }
            }

            var resultEvenAppearance = dictAppearence.Where(x => x.Value % 2 == 0).Select(x => x.Key).ToList();
            //Print result
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(string.Join(" ",resultEvenAppearance));
        }
    }
}
