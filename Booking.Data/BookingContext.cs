using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Booking.Data.Models;

namespace Booking.Data
{
    public class BookingContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public DbSet<ClientType> ClientTypes { get; set; }
        public DbSet<Resort> Resorts { get; set; }
        public DbSet<ResortType> ResortTypes { get; set; }

        public BookingContext(DbContextOptions options)
            : base(options)
        {

        }

        protected BookingContext()
        {

        }
    }
}
