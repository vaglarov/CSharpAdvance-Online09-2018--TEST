namespace _106.__AutoRepairAndService
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class AutoRepairAndService
    {
        static void Main(string[] args)
        {
            var inputAllCars = Console.ReadLine().
                Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var allCars = new List<Car>();
            var queueWaitingCar = new Queue<Car>();
            var stackFinishedCar = new Stack<Car>();
            // Fill Queue with all cars
            for (int i = 0; i < inputAllCars.Length; i++)
            {
                var car = new Car(inputAllCars[i]);
                allCars.Add(car);
                queueWaitingCar.Enqueue(car);
            }

            // Doing commands
            var command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                var splitCommand = command.Split("-", StringSplitOptions.RemoveEmptyEntries);
                switch (splitCommand[0])
                {
                    case "Service":
                        var carService = queueWaitingCar.Dequeue();
                        carService.IsServised = true;
                        stackFinishedCar.Push(carService);
                        break;
                    case "CarInfo":
                        var currentCarName = splitCommand[1];
                        bool carIsFound = false;
                        foreach (var car in allCars)
                        {
                            if (car.CarName == currentCarName)
                            {
                                carIsFound = true;
                                if (car.IsServised)
                                {
                                    Console.WriteLine("Served.");
                                }
                                else
                                {
                                    Console.WriteLine("Still waiting for service.");
                                }
                                break;
                            }
                        }
                        if (!carIsFound)
                        {
                            Console.WriteLine("The car doesn't exist!, Please, try again!");
                        }
                        break;

                    case "History":
                        var result = stackFinishedCar.Select(x => x.CarName).ToList();
                        Console.WriteLine(string.Join(", ", result));
                        break;
                    default:
                        Console.WriteLine("Wrong input!! Try again");
                        break;
                }

            }

            // Print result
            //Vehicles for service: 
            var stillWaiting = queueWaitingCar.Select(x => x.CarName).ToList();
            Console.WriteLine($"Vehicles for service: "+string.Join(", ",stillWaiting));
            var stackServeseresult = stackFinishedCar.Select(x => x.CarName).ToList();
            Console.WriteLine($"Served vehicles: " + string.Join(", ", stackServeseresult));
        }
    }
}
