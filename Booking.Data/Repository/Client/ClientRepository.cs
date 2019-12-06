using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Booking.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Booking.Data.Repository.Client
{
    internal class ClientRepository : IClientRepository
    {
        private readonly BookingContext _context;

        public ClientRepository(BookingContext context)
        {
            _context = context;
        }

        public byte Create(Models.Client client)
        {
            //client.ClientTypeId = client.ClientType.Id;
            //client.ClientType = null;

            _context.Clients.Add(client);
            _context.Entry(client.ClientType).State = EntityState.Unchanged;
            _context.SaveChanges();

            return client.Id;
        }

        public void Detele(byte id)
        {
            var client = _context.Clients.SingleOrDefault(c => c.Id == id);

            _context.Clients.Remove(client);
            _context.SaveChanges();
        }

        public Models.Client Get(byte id)
        {
            var client =_context.Clients
                .Include(c => c.ClientType)
                .SingleOrDefault(c => c.Id == id);

            return client;
        }

        public IEnumerable<Models.Client> List() => _context.Clients
            .Include(c => c.ClientType)
            .ToList();

        public void Update(Models.Client client)
        {
            _context.Clients.Attach(client);
            _context.Entry(client).State = EntityState.Modified;
            _context.Entry(client.ClientType).State = EntityState.Unchanged;
            _context.SaveChanges();
        }
    }
}
