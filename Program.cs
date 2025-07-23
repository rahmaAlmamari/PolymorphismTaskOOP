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



        }
    }
}
