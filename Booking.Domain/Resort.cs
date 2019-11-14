using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Domain
{
    class Resort
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public ResortType Type { get; set; }
        public byte ResortTypeId { get; set; }
        public short Capacity { get; set; }
        public short Rooms { get; set; }
        public byte Rating { get; set; }
        public float Price { get; set; }
    }
}
