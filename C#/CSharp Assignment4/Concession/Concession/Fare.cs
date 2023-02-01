using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concession
{
    public class Fare
    {
        const double TotalFare = 500;
        public void CalculateConsession(int age)
        {
            if (age < 5)
            {
                Console.WriteLine("Little Champs- Free Ticket");
            }
            else if(age > 60)
            {
                double consession = TotalFare * 0.3d;
                double fare = TotalFare - consession;
                Console.WriteLine($"Senior Citizen: {fare}");
            }
            else
            {
                Console.WriteLine("Ticket Booked: " + TotalFare);
            }
        }
    }
}
