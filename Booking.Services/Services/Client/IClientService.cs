using System;
using System.Collections.Generic;
using System.Text;
using Booking.Domain;

namespace Booking.Services.Services.Client
{
    public interface IClientService
    {
        IEnumerable<Domain.Client> List();
        Domain.Client Get(byte id);
        byte Create(Domain.Client client);
        void Update(Domain.Client client);
        void Delete(byte id);

    }
}
