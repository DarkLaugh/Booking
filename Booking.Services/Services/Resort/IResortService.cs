using System;
using System.Collections.Generic;
using System.Text;
using Booking.Domain;

namespace Booking.Services.Services.Resort
{
    public interface IResortService
    {
        IEnumerable<Domain.Resort> List();
        Domain.Resort Get(byte id);
        byte Create(Domain.Resort resort);
        void Update(Domain.Resort resort);
        void Delete(byte id);
    }
}
