using System.Security.Cryptography.X509Certificates;

namespace PolymorphismTaskOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            // Adding some cars to the list
            cars.Add(new Car { Brand = "Toyota", Model = "Camry", Year = 2015, LicensePlate = "ABC123", IsLuxury = false });
            cars.Add(new Car { Brand = "Mercedes", Model = "S-Class", Year = 2018, LicensePlate = "XYZ789", IsLuxury = true });
            cars.Add(new Car { Brand = "Honda", Model = "Civic", Year = 2010, LicensePlate = "LMN456", IsLuxury = false });

            //-------------------------------------------------------
            List<Motorbike> motorbikes = new List<Motorbike>();
            // Adding some motorbikes to the list
            motorbikes.Add(new Motorbike { Brand = "Yamaha", Model = "R1", Year = 2019, LicensePlate = "BIKE123", RequiresHelmet = true });
            motorbikes.Add(new Motorbike { Brand = "Kawasaki", Model = "Ninja", Year = 2012, LicensePlate = "BIKE456", RequiresHelmet = false });

            //-------------------------------------------------------
            List<Truck> trucks = new List<Truck>();
            // Adding some trucks to the list
            trucks.Add(new Truck { Brand = "Ford", Model = "F-150", Year = 2020, LicensePlate = "TRUCK123", MaxLoadKg = 1000 });
            trucks.Add(new Truck { Brand = "Volvo", Model = "FH16", Year = 2015, LicensePlate = "TRUCK456", MaxLoadKg = 2000 });

            //-------------------------------------------------------

            // Displaying Available Vehicles ...
            Console.WriteLine("--- SmartCar Rentals System --- \n");
            Console.WriteLine("Available Cars:");
            foreach (var car in cars)
            {
                car.PrintCarDetails();
            }
            Console.WriteLine("\nAvailable Motorbikes:");
            foreach (var motorbike in motorbikes)
            {
                motorbike.PrintMotorbikeDetails();
            }
            Console.WriteLine("\nAvailable Trucks:");
            foreach (var truck in trucks)
            {
                truck.PrintTruckDetails();
            }

            //-------------------------------------------------------
            //to ask the user to select a vehicle type ...
            Console.WriteLine("\nSelect a vehicle type to rent:\n" + 
                              "1. Car\n" + 
                              "2. Motorbike\n" + 
                              "3. Truck");
            int vehicleType = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of days you want to rent the vehicle:");
            int days = int.Parse(Console.ReadLine());
            double rentalCost = 0;
            switch (vehicleType)
            {
                case 1: // Car
                    Console.WriteLine("Do you want a driver? (yes/no)");
                    bool withDriverCar = Console.ReadLine().ToLower() == "yes";
                    Console.WriteLine("Is the car luxury? (yes/no)");
                    bool isLuxuryCar = Console.ReadLine().ToLower() == "yes";
                    rentalCost = cars[0].CalculateRentalCost(days, withDriverCar, isLuxuryCar);
                    if (rentalCost < 0)
                    {
                        Console.WriteLine("This car cannot be rented.");
                    }
                    else
                    {
                        Console.WriteLine($"Total rental cost for the car: {rentalCost}");
                    }
                    break;
                case 2: // Motorbike
                    Console.WriteLine("Do you want a driver? (yes/no)");
                    bool withDriverBike = Console.ReadLine().ToLower() == "yes";
                    Console.WriteLine("Does the motorbike require a helmet? (yes/no)");
                    bool requiresHelmet = Console.ReadLine().ToLower() == "yes";
                    rentalCost = motorbikes[0].CalculateRentalCost(days, withDriverBike, requiresHelmet);
                    if (rentalCost < 0)
                    {
                        Console.WriteLine("This motorbike cannot be rented.");
                    }
                    else
                    {
                        Console.WriteLine($"Total rental cost for the motorbike: {rentalCost}");
                    }
                    break;
                case 3: // Truck
                    Console.WriteLine("Do you want a driver? (yes/no)");
                    bool withDriverTruck = Console.ReadLine().ToLower() == "yes";
                    Console.WriteLine("Enter the maximum load in kg:");
                    double maxLoadKg = double.Parse(Console.ReadLine());
                    rentalCost = trucks[0].CalculateRentalCost(days, withDriverTruck, maxLoadKg);
                    if (rentalCost < 0)
                    {
                        Console.WriteLine("This truck cannot be rented.");
                    }
                    else
                    {
                        Console.WriteLine($"Total rental cost for the truck: {rentalCost}");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid vehicle type selected.");
                    break;
            }



        }
    }
}
