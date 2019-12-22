using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.WebApi.ViewModels
{
    public class FindUserViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public string UserName { get; set; }
        public byte ClientTypeId { get; set; }
    }
}
