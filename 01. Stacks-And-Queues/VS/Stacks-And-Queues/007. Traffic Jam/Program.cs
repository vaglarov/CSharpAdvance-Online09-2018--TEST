using System;
using System.Collections.Generic;

namespace _007._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCarPassGreeen = int.Parse(Console.ReadLine());
            var queueOnCrossRoad = new Queue<string>();
            string command = string.Empty;
            int countPass = 0;
            while ((command=Console.ReadLine())!= "end")
            {
                if (command!="green")
                {
                    queueOnCrossRoad.Enqueue(command);
                }
                else if(queueOnCrossRoad.Count>0)
                {
                    for (int i = 1; i <= numberCarPassGreeen; i++)
                    {
                        if (queueOnCrossRoad.Count!=0)
                        {
                            countPass++;
                            Console.WriteLine($"{queueOnCrossRoad.Dequeue()} passed!");
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            Console.WriteLine($"{countPass} cars passed the crossroads.");
        }
    }
}
