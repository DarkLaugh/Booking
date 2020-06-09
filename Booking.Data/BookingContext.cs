using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Booking.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Booking.Data.Configure;

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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ClientTypeConfiguration());
            builder.ApplyConfiguration(new ResortTypeConfiguration());
            base.OnModelCreating(builder);
        }

        protected BookingContext()
        {

        }
    }
}
