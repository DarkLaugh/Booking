using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Booking.Domain;

namespace Booking.Services.Services.User
{
    public interface IUserService
    {
        Task<string> Create(Domain.User user);
    }
}
