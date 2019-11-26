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
            _context.Add(client);
            _context.SaveChanges();

            return client.Id;
        }

        public void Detele(byte id)
        {
            var client = _context.Clients.SingleOrDefault(c => c.Id == id);

            _context.Remove(client);
            _context.SaveChanges();
        }

        public Models.Client Get(byte id) => _context.Clients.SingleOrDefault(c => c.Id == id);

        public IEnumerable<Models.Client> List() => _context.Clients.ToList();

        public void Update(Models.Client client)
        {
            _context.Attach(client);
            _context.Entry(client).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
