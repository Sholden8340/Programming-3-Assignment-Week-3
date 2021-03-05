using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Reservation
    {
        public Customer Customer { get; set; }
        public List<Ticket> Tickets { get; set; }

        public decimal TotalPrice
        {
            get
            {
                decimal total = 0;
                foreach (Ticket ticket in Tickets)
                {
                    if (Customer.Age < ticket.MinimumAge)
                    {
                        throw new Exception($"You are not old enough ({Customer.Age}) to see this Movie rated {ticket.MinimumAge}");
                    }
                    total += ticket.Discount ? ticket.Price * 0.95m : ticket.Price;
                }

                return Customer.Discount ? total * 0.9m : total;
            }
        }

        public Reservation(Customer customer)
        {
            this.Customer = customer;
            this.Tickets = new List<Ticket>();
        }
    }
}
