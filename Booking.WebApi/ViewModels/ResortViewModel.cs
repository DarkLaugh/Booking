using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.WebApi.ViewModels
{
    public class ResortViewModel
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public byte ResortTypeId { get; set; }
        public short Capacity { get; set; }
        public short Rooms { get; set; }
        public byte Rating { get; set; }
        public float Price { get; set; }
    }
}
