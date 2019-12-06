using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Booking.Domain;

namespace Booking.WebApi.ViewModels
{
    public class ClientViewModel
    {
        public byte Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public byte ClientTypeId { get; set; }
    }
}
