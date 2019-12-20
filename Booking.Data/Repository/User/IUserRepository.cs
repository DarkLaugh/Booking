using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Data.Repository.User
{
    public interface IUserRepository
    {
        Task<string> Create(Models.User user);
    }
}
