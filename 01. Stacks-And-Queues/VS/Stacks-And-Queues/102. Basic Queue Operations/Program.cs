using System;
using System.Collections.Generic;
using System.Linq;

namespace _102._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLineInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int numberElementInQueue = int.Parse(firstLineInput[0]);
            int numberDequeuqElements = int.Parse(firstLineInput[1]);
            int seachingNumber = int.Parse(firstLineInput[2]);
            var queueElements = new Queue<int>(numberElementInQueue);
            var elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            foreach (var item in elements)
            {
                queueElements.Enqueue(item);
            }
            for (int i = 0; i < numberDequeuqElements; i++)
            {
                if (queueElements.Count==0)
                {
                    break;
                }
                queueElements.Dequeue();
            }
            if (queueElements.Contains(seachingNumber)&&queueElements.Count>0)
            {
                Console.WriteLine("true");
            }
            else if (queueElements.Count==0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine($"{queueElements.Min()}");
            }
        }
    }
}
