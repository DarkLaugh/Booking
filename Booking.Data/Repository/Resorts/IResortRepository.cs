using System;
using Booking.Data;
using System.Collections.Generic;
using System.Text;

namespace Booking.Data.Repository.Resorts
{
    public interface IResortRepository
    {
        IEnumerable<Models.Resort> List();
        Models.Resort Get(byte id);
        byte Create(Models.Resort resort);
        void Update(Models.Resort resort);
        void Delete(byte id);
    }
}
