using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Domain
{
    public class Resort
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public ResortType ResortType { get; set; }
        public short Capacity { get; set; }
        public short Rooms { get; set; }
        public byte Rating { get; set; }
        public float Price { get; set; }
    }
}
