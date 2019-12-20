using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Booking.Services.Services.Client;
using Booking.Data.DependencyInjection;
using Booking.Services.Services.Resort;
using Booking.Services.Services.Reservation;
using Booking.Services.Services.User;

namespace Booking.Services.Dependency_Injection
{
    public static class BookingServiceModule
    {
        public static IServiceCollection AddServiceDataModule(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddBookingDataModule(configuration);

            services.AddScoped<IClientService, ClientService>();

            services.AddScoped<IResortService, ResortService>();

            services.AddScoped<IReservationService, ReservationService>();

            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
