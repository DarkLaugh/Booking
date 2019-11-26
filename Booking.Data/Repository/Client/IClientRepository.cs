using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Data.Repository.Client
{
    public interface IClientRepository
    {
        IEnumerable<Models.Client> List();

        Models.Client Get(byte id);

        byte Create(Models.Client client);

        void Update(Models.Client client);

        void Detele(byte id);
    }
}
