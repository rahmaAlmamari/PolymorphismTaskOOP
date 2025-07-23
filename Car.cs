using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismTaskOOP
{
    class Car : Vehicle
    {
        //1. class fields ...
        public bool IsLuxury;
        //2. class properties ...
        //3. class methods ...
        //override method ...
        public override double CalculateRentalCost(int days)
        {
            // to check if Vehicle is older than 10 years ...
            if (IsOlderThan10Years())
            {
                return -1; // Return -1 to indicate that the vehicle cannot be rented
            }
            if (IsLuxury)
            {
                return days * 80; // Luxury car rate
            }
            else
            {
                return days * 60; // Regular car rate
            }
        }
        //overload method ...
        public double CalculateRentalCost(int days, bool withDriver, bool is_luxury)
        {
            double cost = CalculateRentalCost(days); // Call the base method to get the cost
            if (cost < 0) // If the vehicle is too old for rental
            {
                return -1; // Return -1 to indicate that the vehicle cannot be rented
            }
            if (withDriver && is_luxury)
            {
                cost += 100 * days * 80; // Add driver cost of 100 per day
            }
            else if (withDriver)
            {
                cost += 100 * days * 60; // Add driver cost of 100 per day for regular car
            }
            else if (is_luxury)
            {
                cost += 80 * days; // Additional luxury fee
            }
            else
            {
                cost += 60 * days; // Additional regular fee
            }
            return cost; // Return the total cost
        }
        //to print the car details ...
        public void PrintCarDetails()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}, License Plate: {LicensePlate}, Is Luxury: {IsLuxury}");
        }

        //4. class constructor ...
    }
}
