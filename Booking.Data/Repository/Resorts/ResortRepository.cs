using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Booking.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Booking.Data.Repository.Resorts
{
    internal class ResortRepository : IResortRepository
    {
        private readonly BookingContext _context;

        public ResortRepository(BookingContext context)
        {
            _context = context;
        }

        public byte Create(Resort resort)
        {
            _context.Resorts.Add(resort);
            _context.Entry(resort.ResortType).State = EntityState.Unchanged;
            _context.SaveChanges();

            return resort.Id;
        }

        public void Delete(byte id)
        {
            var resort = _context.Resorts.SingleOrDefault(r => r.Id == id);

            _context.Resorts.Remove(resort);
            _context.SaveChanges();
        }

        public Resort Get(byte id)
        {
            var resort = _context.Resorts.
                Include(r => r.ResortType)
                .SingleOrDefault(r => r.Id == id);

            return resort;
        }

        public IEnumerable<Resort> List()
        {
            return _context.Resorts.Include(r => r.ResortType).ToList();
        }

        public void Update(Resort resort)
        {
            _context.Resorts.Attach(resort);
            _context.Entry(resort).State = EntityState.Modified;
            _context.Entry(resort.ResortType).State = EntityState.Unchanged;
            _context.SaveChanges();
        }
    }
}
