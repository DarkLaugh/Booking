using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Booking.Domain;
using Booking.Data;

namespace Booking.Services.AutoMapperProfile
{
    public class ServicesMapperProfile : Profile
    {
        public ServicesMapperProfile()
        {
            CreateMap<Client, Data.Models.Client>().ReverseMap();
        }
    }
}
