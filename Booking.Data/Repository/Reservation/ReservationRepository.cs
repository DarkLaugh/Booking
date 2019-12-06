using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Booking.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Booking.Data.Repository.Reservation
{
    internal class ReservationRepository : IReservationRepository
    {
        private readonly BookingContext _context;

        public ReservationRepository(BookingContext context)
        {
            _context = context;
        }


        public byte Create(Models.Reservation reservation)
        {
            _context.Reservations.Add(reservation);
            _context.Entry(reservation.Resort).State = EntityState.Unchanged;
            _context.Entry(reservation.Client).State = EntityState.Unchanged;
            _context.SaveChanges();

            return reservation.Id;
        }

        public void Delete(byte id)
        {
            var reservation = _context.Reservations.SingleOrDefault(r => r.Id == id);

            _context.Reservations.Remove(reservation);
            _context.SaveChanges();
        }

        public Models.Reservation Get(byte id)
        {
            var reservation = _context.Reservations
                .Include(r => r.Client.ClientType)
                .Include(r => r.Resort.ResortType)
                .SingleOrDefault(r => r.Id == id);

            return reservation;
        }

        public IEnumerable<Models.Reservation> List()
        {
            var list = _context.Reservations.ToList();

            return list;
        }
    }
}
