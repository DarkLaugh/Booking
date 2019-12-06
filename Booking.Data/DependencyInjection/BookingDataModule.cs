using System;
using System.Collections.Generic;
using System.Text;
using Booking.Data.Repository.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Booking.Data.Repository.Resorts;
using Booking.Data.Repository.Reservation;

namespace Booking.Data.DependencyInjection
{
    public static class BookingDataModule
    {
        public static IServiceCollection AddBookingDataModule(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BookingContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("BookingDatabase")));

            services.AddScoped<IClientRepository, ClientRepository>();

            services.AddScoped<IResortRepository, ResortRepository>();

            services.AddScoped<IReservationRepository, ReservationRepository>();

            return services;
        }
    }
}
