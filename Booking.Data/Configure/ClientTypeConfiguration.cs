using Booking.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Data.Configure
{
    public class ClientTypeConfiguration : IEntityTypeConfiguration<ClientType>
    {
        public void Configure(EntityTypeBuilder<ClientType> builder)
        {
            builder.HasData
                (
                    new ClientType
                    {
                        Id = 1,
                        DiscountRate = 30,
                        Name = "VIP"
                    },
                    new ClientType
                    {
                        Id = 2,
                        DiscountRate = 15,
                        Name = "Regular"
                    },
                    new ClientType
                    {
                        Id = 3,
                        DiscountRate = 0,
                        Name = "Normal"
                    }
                );
        }
    }
}
