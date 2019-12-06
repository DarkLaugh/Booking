using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Domain
{
    public class Reservation
    {
        public byte Id { get; set; }
        public Client Client { get; set; }
        public Resort Resort { get; set; }
    }
}
