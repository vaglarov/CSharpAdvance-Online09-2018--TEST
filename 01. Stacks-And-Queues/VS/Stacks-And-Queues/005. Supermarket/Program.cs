using System;
using System.Collections.Generic;

namespace _005._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            var queueShop = new Queue<string>();
            while ((command=Console.ReadLine())!= "End")
            {
                if (command!="Paid")
                {
                    queueShop.Enqueue(command);
                }
                else
                {
                    while (queueShop.Count > 0)
                    {
                        Console.WriteLine($"{queueShop.Dequeue()}");
                    }
                }
            }
            //Print
            Console.WriteLine($"{queueShop.Count} people remaining.");
        }
    }
}
