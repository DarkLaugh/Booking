using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Booking.Data.Repository.Reservation;
using Booking.Domain;

namespace Booking.Services.Services.Reservation
{
    public class ReservationService : IReservationService
    {
        private readonly IMapper _mapper;
        private readonly IReservationRepository _repository;

        public ReservationService(IMapper mapper, IReservationRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public byte Create(Domain.Reservation reservation)
        {
            var entity = _mapper.Map<Data.Models.Reservation>(reservation);

            return _repository.Create(entity);
        }

        public void Detele(byte id)
        {
            _repository.Delete(id);
        }

        public Domain.Reservation Get(byte id)
        {
            var entity = _repository.Get(id);

            return _mapper.Map<Domain.Reservation>(entity);
        }

        public IEnumerable<Domain.Reservation> List()
        {
            var list = _repository.List();

            return _mapper.Map<IEnumerable<Domain.Reservation>>(list);
        }
    }
}
