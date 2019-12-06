using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Booking.Data.Models
{
    public class Reservation
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Id { get; set; }
        public Client Client { get; set; }
        public byte ClientId { get; set; }
        public Resort Resort { get; set; }
        public byte ResortId { get; set; }
    }
}
