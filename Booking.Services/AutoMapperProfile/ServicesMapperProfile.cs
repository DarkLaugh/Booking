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
            CreateMap<Booking.Data.Models.Client, Client>().ReverseMap();

            CreateMap<Booking.Data.Models.ClientType, ClientType>().ReverseMap();

            CreateMap<Resort, Data.Models.Resort>().ReverseMap();

            CreateMap<ResortType, Data.Models.ResortType>().ReverseMap();

            CreateMap<Reservation, Data.Models.Reservation>().ReverseMap();
        }
    }
}
