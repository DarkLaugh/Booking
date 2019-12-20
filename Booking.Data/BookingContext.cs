using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Booking.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Booking.Data
{
    public class BookingContext : IdentityDbContext<User>
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientType> ClientTypes { get; set; }
        public DbSet<Resort> Resorts { get; set; }
        public DbSet<ResortType> ResortTypes { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        public BookingContext(DbContextOptions options)
            : base(options)
        {

        }

        protected BookingContext()
        {

        }
    }
}
