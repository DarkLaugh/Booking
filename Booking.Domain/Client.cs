using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Domain
{
    public class Client
    {
        public byte Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public ClientType ClientType { get; set; }    }
}
