using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bookking
{
    public class BMTest
    {
        private int buffId = 1;
        private List<Customer> customers = new List<Customer>();
        private List<Booking> bookings = new List<Booking>();
        private List<Dates> dates = new List<Dates>();

        public BMTest(List<Customer> customers, List<Booking> bookings, List<Dates> dates)
        {
            this.customers = customers;
            this.bookings = bookings;
            this.dates = dates;
        }

        public void addBooking()
        {
            string name = Console.ReadLine();
            int id = buffId;
            buffId++;
            int startDay = int.Parse(Console.ReadLine());
            int startMonth = int.Parse(Console.ReadLine());
            int endDay = int.Parse(Console.ReadLine());
            int endMonth = int.Parse(Console.ReadLine());
            Dates startDate = new Dates(startDay, startMonth);
            Dates endDate = new Dates(endDay, endMonth);
            foreach (var date in dates)
            {
                if (startDate.Month == endDate.Month) 
                {
                    for (int i = startDate.DayOfMonth; i <= endDate.DayOfMonth; i++) 
                    { 
                         Dates date0 = new Dates(i, startDate.Month);
                        if (date0.DayOfMonth == date.DayOfMonth)
                        {
                            if (date0.Month == date.Month)
                            {
                                Console.WriteLine("Day not available");
                                return;
                            }
                         
                        }
                    }
                }
                else
                {
                    if(startDate.Month == 2)
                    {
                        for(int i = startDate.DayOfMonth; i <= 28; i++)
                        {
                            Dates date1 = new Dates(i, 2);
                            if (date1.DayOfMonth == date.DayOfMonth)
                            {
                                if (date1.Month == date.Month)
                                {
                                    Console.WriteLine("Day not available");
                                    return;
                                }

                            }
                        }
                    }
                    else if(startDate.Month == 1 || startDate.Month == 3 || startDate.Month == 5 || startDate.Month == 7 || startDate.Month == 8 || startDate.Month == 10 || startDate.Month == 12)
                    {
                        for (int i = startDate.DayOfMonth; i <= 31; i++)
                        {
                            Dates date2 = new Dates(i, startDate.Month);
                            if (date2.DayOfMonth == date.DayOfMonth)
                            {
                                if (date2.Month == date.Month)
                                {
                                    Console.WriteLine("Day not available");
                                    return;
                                }

                            }
                        }
                    }
                    else if (startDate.Month == 4 || startDate.Month == 6 || startDate.Month == 9 || startDate.Month ==11)
                    {
                        for (int i = startDate.DayOfMonth; i <= 30; i++)
                        {
                            Dates date3 = new Dates(i, startDate.Month);
                            if (date3.DayOfMonth == date.DayOfMonth)
                            {
                                if (date3.Month == date.Month)
                                {
                                    Console.WriteLine("Day not available");
                                    return;
                                }

                            }
                        }
                    }
                    for (int i = 1; i <= endDate.DayOfMonth; i++) 
                    {
                        Dates date4 = new Dates(i, endDate.Month);
                        if (date4.DayOfMonth == date.DayOfMonth)
                        {
                            if (date4.Month == date.Month)
                            {
                                Console.WriteLine("Day not available");
                                return;
                            }

                        }
                    }
                }
            }
            if (startDate.Month == endDate.Month)
            {
                for (int i = startDate.DayOfMonth; i <= endDate.DayOfMonth; i++)
                {
                   Dates date0 = new Dates(i, startDate.Month);
                    dates.Add(date0);   
                }
            }
            else
            {
                if (startDate.Month == 2)
                {
                    for (int i = startDate.DayOfMonth; i <= 28; i++)
                    {
                        Dates date1 = new Dates(i, 2);
                        dates.Add(date1);
                    }
                }
                else if (startDate.Month == 1 || startDate.Month == 3 || startDate.Month == 5 || startDate.Month == 7 || startDate.Month == 8 || startDate.Month == 10 || startDate.Month == 12)
                {
                    for (int i = startDate.DayOfMonth; i <= 31; i++)
                    {
                        Dates date2 = new Dates(i, startDate.Month);
                        dates.Add(date2);
                    }
                }
                else if (startDate.Month == 4 || startDate.Month == 6 || startDate.Month == 9 || startDate.Month == 11)
                {
                    for (int i = startDate.DayOfMonth; i <= 30; i++)
                    {
                        Dates date3 = new Dates(i, startDate.Month);
                        dates.Add(date3);
                    }
                }
                for (int i = 1; i <= endDate.DayOfMonth; i++)
                {
                    Dates date4 = new Dates(i, endDate.Month);
                    dates.Add(date4);
                }
            }
            int phoneNumber = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            foreach (Customer customer in customers) 
            {
                if (phoneNumber == customer.Telephone) 
                { 
                   Booking booking = new Booking(BookingTypes.Hotel, name, id, capacity, customer, startDate, endDate); 
                   bookings.Add(booking);
                }
            }
        }
        public void addCustomer()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int phoneNumber = int.Parse(Console.ReadLine());
            Customer customer = new Customer(firstName, lastName, phoneNumber);
            customers.Add(customer);
        }

        public void cancelBooking() 
        { 
            int id = int.Parse(Console.ReadLine());
            foreach (Booking booking in bookings)
            {
                if (booking.BookingId == id)
                {
                    bookings.Remove(booking);
                }
            }
        }
    }

}
