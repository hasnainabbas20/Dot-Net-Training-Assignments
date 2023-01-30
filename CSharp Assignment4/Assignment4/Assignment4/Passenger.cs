using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class TicketException : ApplicationException
    {
        public TicketException(string message) : base(message)
        {

        }
    }

    class Passenger
    {
        public string Name;
        public int Age;

        public void TicketBooking(int no_of_tickets)
        {
            if(no_of_tickets > 2)
            {
                throw (new TicketException("cannot book more than 2 tickets"));
            }
            else
            {
                Console.WriteLine("Ticket Booked Successfully");
            }
        }
    }

    class Test
    {
        static void Main()
        {
            Passenger passenger = new Passenger();
            Console.Write("Enter Name: "); passenger.Name = Console.ReadLine();
            Console.Write("Enter Age: "); passenger.Age = int.Parse(Console.ReadLine());
            Console.Write("Enter number of tickets to be booked: "); int numberoftickets = int.Parse(Console.ReadLine());
            try
            {
                passenger.TicketBooking(numberoftickets);
            }
            catch(TicketException te)
            {
                Console.WriteLine(te.Message);
            }
            Console.Read();
        }
    }
}
