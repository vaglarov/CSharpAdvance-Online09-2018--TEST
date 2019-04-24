using System;
using System.Collections.Generic;

namespace _006._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var hotPopatoQueue = new Queue<string>(input);
            int timerExplodePopato = int.Parse(Console.ReadLine());
            while (hotPopatoQueue.Count>1)
            {
                for (int i = 1; i < timerExplodePopato; i++)
                {
                    hotPopatoQueue.Enqueue(hotPopatoQueue.Dequeue());
                }
                Console.WriteLine($"Removed {hotPopatoQueue.Dequeue()}");
            }
            Console.WriteLine($"Last is {hotPopatoQueue.Dequeue()}");
        }
    }
}
