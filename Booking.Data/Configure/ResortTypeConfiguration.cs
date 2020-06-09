using Booking.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Data.Configure
{
    public class ResortTypeConfiguration : IEntityTypeConfiguration<ResortType>
    {
        public void Configure(EntityTypeBuilder<ResortType> builder)
        {
            builder.HasData
                (
                    new ResortType
                    {
                        Id = 1,
                        Name = "Summer"
                    },
                    new ResortType
                    {
                        Id = 2,
                        Name = "Winter"
                    }
                );
        }
    }
}
