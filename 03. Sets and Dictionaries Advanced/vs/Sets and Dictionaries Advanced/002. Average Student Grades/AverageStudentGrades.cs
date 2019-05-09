namespace _002._Average_Student_Grades
{
using System;
    using System.Collections.Generic;
    using System.Linq;

    class AverageStudentGrades
    {
        static void Main(string[] args)
        {
            int numberLineInput = int.Parse(Console.ReadLine());
            var dictName = new Dictionary<string, List<double>>();
            
            //Fill dictionary with values

            for (int index = 0; index < numberLineInput; index++)
            {
                var input = Console.ReadLine().Split();
                var nameStudent = input[0];
                var mark = double.Parse(input[1]);
                if (!dictName.ContainsKey(nameStudent))
                {
                    dictName.Add(nameStudent, new List<double>());
                }
                dictName[nameStudent].Add(mark);
            }

            //Print Dictionary

            foreach (var kvp in dictName.OrderByDescending(x=>x.Value.Average()))
            {
                Console.WriteLine($"{kvp.Key} -> {PrintListInDict(kvp.Value)} (avg: {kvp.Value.Average():f2})");
            }
        }

        private static string PrintListInDict(List<double> list)
        {
            var result = string.Empty;
            foreach (var item in list)
            {
                result += $" {item:F2}";
            }
            result = result.TrimStart(' ');
            return result;
        }
    }
}
