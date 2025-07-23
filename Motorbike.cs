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
        //4. class constructor ...
    }
}
