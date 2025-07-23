using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismTaskOOP
{
    class Motorbike : Vehicle
    {
        //1. class fields ...
        public bool RequiresHelmet;
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
            if (RequiresHelmet)
            {
                return days * 40; // Motorbike with helmet rate
            }
            else
            {
                return days * 30; // Regular motorbike rate
            }
        }
        //overload method ...
        public double CalculateRentalCost(int days, bool withDriver, bool requiresHelmet)
        {
            double cost = CalculateRentalCost(days); // Call the base method to get the cost
            if (cost < 0) // If the vehicle is too old for rental
            {
                return -1; // Return -1 to indicate that the vehicle cannot be rented
            }
            if (withDriver && requiresHelmet)
            {
                cost += 100 * days * 40; // Add driver cost of 100 per day for motorbike with helmet
            }
            else if (withDriver)
            {
                cost += 100 * days * 30; // Add driver cost of 100 per day for regular motorbike
            }
            else if (requiresHelmet)
            {
                cost += 40 * days; // Additional helmet fee
            }
            else
            {
                cost += 30 * days; // Additional regular fee
            }
            return cost; // Return the total cost
        }
        //4. class constructor ...
    }
}
