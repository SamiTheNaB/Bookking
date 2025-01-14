using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookking
{
    public class Booking
    {
        BookingTypes bookingType;
        private string bookingName;
        int bookingId;
        Customer bookingOwner;
        private int capacity;
        bool booked = false;
        private Dates startDate;
        private Dates endDate;


        public BookingTypes BookingType
        {
            get => bookingType;
            set => bookingType = value;
        }

        public string BookingName
        {
            get => bookingName;
            set => bookingName = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int BookingId
        {
            get => bookingId;
            set => bookingId = value;
        }


        public Customer BookingOwner
        {
            get => bookingOwner;
            set => bookingOwner = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int Capacity
        {
            get => capacity;
            set => capacity = value;
        }

        public Booking(BookingTypes bookingType = default, string bookingName = default, int bookingId = default, int capacity = default, Customer bookingOwner = null, Dates startDate = null, Dates endDate = null)
        {
            this.BookingType = bookingType;
            this.BookingName = bookingName;
            this.BookingId = bookingId;
            this.Capacity = capacity;
            this.BookingOwner = bookingOwner;
            this.startDate = startDate;
            this.endDate = endDate;
        }
    }
}
