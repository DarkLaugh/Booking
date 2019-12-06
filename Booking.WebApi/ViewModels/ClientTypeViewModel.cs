using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.WebApi.ViewModels
{
    public class ClientTypeViewModel
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public byte DiscountRate { get; set; }
    }
}
