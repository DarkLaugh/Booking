using Booking.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.WebApi.ViewModels
{
    public class ReservationViewModel
    {
        public byte Id { get; set; }
        public byte ClientId { get; set; }
        public byte ResortId { get; set; }
    }
}
