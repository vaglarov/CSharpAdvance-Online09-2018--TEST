namespace _107.__TruckTour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TruckTour
    {
        static void Main(string[] args)
        {
            int numberPetrolStation = int.Parse(Console.ReadLine());
            Queue<int[]> queuePetrolStation = new Queue<int[]>();
            for (int i = 0; i < numberPetrolStation; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                queuePetrolStation.Enqueue(input);
            }
            int numberStartIndex = 0;

            int totalFuel = 0;
            while (totalFuel<=0)
            {
                foreach (var petrolStation in queuePetrolStation)
                {
                    int fuel = petrolStation[0];
                    int distance = petrolStation[1];
                    totalFuel += fuel - distance;
                    if (totalFuel <= 0)
                    {
                        queuePetrolStation.Enqueue(queuePetrolStation.Dequeue());
                        numberStartIndex++;
                        totalFuel = 0;
                        break;
                    }
                }
            }

            Console.WriteLine(numberStartIndex);
        }
    }
}
