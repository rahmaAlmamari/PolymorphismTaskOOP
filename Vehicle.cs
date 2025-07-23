using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismTaskOOP
{
    class Vehicle
    {
        //1. class fields ...
        public string Brand;
        public string Model;
        public int Year;
        public string LicensePlate;
        //2. class properties ...
        //3. class methods ...
        //to check if Vehicle year is older than 10 to current year ...
        public bool IsOlderThan10Years()
        {
            int currentYear = DateTime.Now.Year;
            return (currentYear - Year) > 10;
        }
        //to calculate the rental cost based on the number of days rented ...
        public virtual double CalculateRentalCost(int days)
        {
            //to check if Vehicle is older than 10 years ...
            if (IsOlderThan10Years()) 
            {
                //Console.WriteLine("This vehicle is older than 10 years, rental cost is not available.");
                //Additional.HoldScreen(); // Just to hold the screen for a second ...
                return -1; // Return -1 to tell the system that the vehicle is too old for rental ... 
            }

            //to set discounted rate for more than 7 days ...
            if (days > 7)
            {
                return days * 50; // Discounted rate for more than 7 days ...
            }
            else
            {
                return days * 70; // Regular rate for 7 days or less ...
            }
        }
        //4. class constructor ...
    }
}
