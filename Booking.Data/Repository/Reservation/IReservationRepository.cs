using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Data.Repository.Reservation
{
    public interface IReservationRepository
    {
        IEnumerable<Models.Reservation> List();

        Models.Reservation Get(byte id);

        byte Create(Models.Reservation reservation);

        void Delete(byte id);
    }
}
