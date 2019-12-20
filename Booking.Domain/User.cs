using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Domain
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public byte ClientTypeId { get; set; }
        public ClientType ClientType { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
