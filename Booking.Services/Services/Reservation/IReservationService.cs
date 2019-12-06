using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Services.Services.Reservation
{
    public interface IReservationService
    {
        IEnumerable<Domain.Reservation> List();

        Domain.Reservation Get(byte id);

        byte Create(Domain.Reservation reservation);

        void Detele(byte id);
    }
}
