using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Booking.Domain;
using Booking.WebApi.ViewModels;

namespace Booking.WebApi.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //DomainModel to ViewModel and backwards

            CreateMap<Client, ClientViewModel>().ReverseMap();
            CreateMap<ClientType, ClientTypeViewModel>().ReverseMap();


            CreateMap<Resort, ResortViewModel>().ReverseMap();
            CreateMap<ResortType, ResortTypeViewModel>().ReverseMap();

            CreateMap<Reservation, ReservationViewModel>().ReverseMap();
            CreateMap<Reservation, ReservationGetByIdViewModel>();

            CreateMap<User, UserViewModel>().ReverseMap();
        }
    }
}
