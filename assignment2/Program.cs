using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program cinemaProgram = new Program();
            cinemaProgram.Start();
        }

        void Start()
        {

            // set culture of program
            CultureInfo ci = new CultureInfo("en-GB");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            Customer customerMessi = new Customer("Lionel Messi", DateTime.ParseExact("24/06/1987", "dd/MM/yyyy", ci));
            Customer customerPiet = new Customer("Piet Paulusma",DateTime.ParseExact("15/12/1956", "dd/MM/yyyy", ci));

            PrintCustomer(customerMessi);
            PrintCustomer(customerPiet);

            Reservation r1 = new Reservation(customerMessi);
            Reservation r2 = new Reservation(customerPiet);

            Ticket t1 = new Ticket("Bohemian Rapsody", 10.50m)
            {
                CinemaRoom = 1, MinimumAge = 6, StartTime = DateTime.ParseExact("13/02/2021 21:30", "dd/MM/yyyy HH:mm", ci)
            };
            Ticket t2 = new Ticket("The Prodigy", 10.50m)
            {
                CinemaRoom = 4, MinimumAge = 16, StartTime = DateTime.ParseExact("13/02/2021 22:00", "dd/MM/yyyy HH:mm", ci)
            };
            Ticket t3 = new Ticket("Green Book", 10.50m)
            {
                CinemaRoom = 5, MinimumAge = 12, StartTime = DateTime.ParseExact("15/02/2021 19:00", "dd/MM/yyyy HH:mm", ci)
            };
            
            
            r1.Tickets.Add(t1);
            r1.Tickets.Add(t2);
            r1.Tickets.Add(t3);
            PrintReservation(r1);

            r2.Tickets.Add(t1);
            r2.Tickets.Add(t2);
            r2.Tickets.Add(t3);
            PrintReservation(r2);

            Console.ReadKey();
        }

        void PrintCustomer(Customer customer)
        {
            Console.WriteLine(customer.Name);
            Console.WriteLine("date of birth: {0:d}", customer.DateOfBirth.Date);
            Console.WriteLine("age: {0}", customer.Age);
            Console.WriteLine("discount: {0}\n", customer.Discount ? "yes" : "no");
        }

        void PrintTicket(Ticket ticket)
        {
            Console.WriteLine($"created ticket '{ticket.MovieName}', start time: {ticket.StartTime:dd/MM/yyyy HH:mm}, price: {ticket.Price}, room: {ticket.CinemaRoom} ({ticket.MinimumAge}+)");
        }

        void PrintReservation(Reservation reservation)
        {
            Console.WriteLine($"creating tickets (for {reservation.Customer.Name})");
            foreach (Ticket ticket in reservation.Tickets)
            {
              PrintTicket(ticket);  
            }
            Console.WriteLine("total price of reservation: {0:#.00}\n", reservation.TotalPrice);
        }
    }
}