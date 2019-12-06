using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Booking.Services.Services.Reservation;
using Booking.WebApi.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Booking.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;
        private readonly IMapper _mapper;


        public ReservationController(IMapper mapper, IReservationService reservationService)
        {
            _mapper = mapper;
            _reservationService = reservationService;
        }

        // GET: api/Reservation
        [HttpGet]
        public IEnumerable<ReservationViewModel> GetReservations()
        {
            var reservations = _reservationService.List();

            return _mapper.Map<IEnumerable<ReservationViewModel>>(reservations);
        }

        // GET: api/Reservation/5
        [HttpGet("{id}")]
        public ReservationGetByIdViewModel Get(byte id)
        {
            var reservation = _reservationService.Get(id);

            return _mapper.Map<ReservationGetByIdViewModel>(reservation);
        }

        // POST: api/Reservation
        [HttpPost]
        public ReservationViewModel Post([FromBody] ReservationViewModel reservationViewModel)
        {
            var reservation = _mapper.Map<Domain.Reservation>(reservationViewModel);

            _reservationService.Create(reservation);

            return _mapper.Map<ReservationViewModel>(reservation);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(byte id)
        {
            _reservationService.Detele(id);
        }
    }
}
