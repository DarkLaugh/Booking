using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Domain
{
    class Client
    {
        public uint Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public ClientType Type { get; set; }
        public byte ClientTypeId { get; set; }
    }
}
