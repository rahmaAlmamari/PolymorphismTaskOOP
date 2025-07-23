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
        //4. class constructor ...
    }
}
