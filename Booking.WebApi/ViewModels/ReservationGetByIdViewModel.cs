using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.WebApi.ViewModels
{
    public class ReservationGetByIdViewModel
    {
        public byte Id { get; set; }
        public ClientViewModel Client { get; set; }
        public ResortViewModel Resort { get; set; }
    }
}
