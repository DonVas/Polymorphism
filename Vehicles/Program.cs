namespace Vehicles
{
    using System;
    using Models;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split();

            var car = new Car(double.Parse(input[1]), double.Parse(input[2]), int.Parse(input[3]));

            input = Console.ReadLine()
                .Split();

            var truck = new Truck(double.Parse(input[1]), double.Parse(input[2]), int.Parse(input[3]));

            input = Console.ReadLine()
                .Split();

            var bus = new Bus(double.Parse(input[1]), double.Parse(input[2]), int.Parse(input[3]));

            var count = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < count; i++)
            {
                input = Console.ReadLine()?.Split();

                var command = input[0];
                var type = input[1];
                var value = double.Parse(input[2]);
                
                switch (type)
                {
                    case nameof(Car):
                        ExecuteCommand(car, command, value);
                        break;
                    case nameof(Truck):
                        ExecuteCommand(truck, command, value);
                        break;
                    case nameof(Bus):
                        ExecuteCommand(bus, command, value);
                        break;
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }

        private static void ExecuteCommand(Vehicle vehicle, string command, double value)
        {
            switch (command)
            {
                case "Drive":
                    Console.WriteLine(vehicle.Drive(value));
                    break;
                case "Refuel":
                    try
                    {
                        vehicle.Refuel(value);
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);                   
                    }
                    
                    break;

                case "DriveEmpty":
                    var bus = vehicle as Bus;
                    Console.WriteLine(bus.DriveEmpty(value));
                    break;
            }
        }
    }
}

