using System;
using System.Collections.Generic;
using System.Linq;

namespace _104._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfADay = int.Parse(Console.ReadLine());
            int bestOrder = int.MinValue;
            var inputSecondLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var queueOrder = new Queue<int>(inputSecondLine);
            while (true)
            {
                if (queueOrder.Count==0)
                {
                    Console.WriteLine(bestOrder);
                    Console.WriteLine("Orders complete");
                    break;
                }
                var order = queueOrder.Dequeue();
                if (quantityOfADay>=order)
                {
                    if (bestOrder<order)
                    {
                        bestOrder = order;
                    }
                    quantityOfADay -= order;
                }
                else
                {
                    Console.WriteLine(bestOrder);
                    Console.WriteLine($"Orders left: {order}");
                    break;
                }

            }
        }
    }
}
