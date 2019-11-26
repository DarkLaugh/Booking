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
            //DomainModel to ViewModel
            CreateMap<Client, ClientViewModel>().ReverseMap();
        }
    }
}
