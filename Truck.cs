using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismTaskOOP
{
    class Truck : Vehicle
    {
        //1. class fields ...
        public double MaxLoadKg = 1000;
        //2. class properties ...
        //3. class methods ...
        //override method ...
        public virtual double CalculateRentalCost(int days, double maxKg)
        {
            //to check if Vehicle is older than 10 years ...
            if (IsOlderThan10Years())
            {
                //Console.WriteLine("This vehicle is older than 10 years, rental cost is not available.");
                //Additional.HoldScreen(); // Just to hold the screen for a second ...
                return -1; // Return -1 to tell the system that the vehicle is too old for rental ... 
            }

            //to check if the max load is more than the allowed limit ...
            if (maxKg > MaxLoadKg)
            {
                //Console.WriteLine("The load exceeds the maximum allowed limit.");
                //Additional.HoldScreen(); // Just to hold the screen for a second ...
                return -1; // Return -1 to indicate that the load is too heavy ...
            }

            //to set discounted rate for more than 7 days ...
            if (days > 7)
            {
                return days * 50 * 100; // Discounted rate for more than 7 days ...
            }
            else
            {
                return days * 70 * 100; // Regular rate for 7 days or less ...
            }
        }
        //overload method ...
        public double CalculateRentalCost(int days, bool withDriver, double maxKg)
        {
            double cost = CalculateRentalCost(days, maxKg); // Call the base method to get the cost
            if (cost < 0) // If the vehicle is too old for rental or load is too heavy
            {
                return -1; // Return -1 to indicate that the vehicle cannot be rented
            }
            if (withDriver)
            {
                cost += 100; // Add driver cost of 100 per day
            }
            return cost; // Return the total cost
        }
        //to print the truck details ...
        public void PrintTruckDetails()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}, License Plate: {LicensePlate}, Max Load Kg: {MaxLoadKg}");
        }

        //4. class constructor ...
    }
}
