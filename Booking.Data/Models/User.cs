using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Booking.Data.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public byte ClientTypeId { get; set; }
        public ClientType ClientType { get; set; }

        [NotMapped]
        public string Password { get; set; }
    }
}
