using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Domain
{
    public class ClientType
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public byte DiscountRate { get; set; }
    }
}
