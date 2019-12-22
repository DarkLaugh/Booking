using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Data.Repository.User
{
    public interface IUserRepository
    {
        Task<string> Create(Models.User user);
        Task<bool> UserExists(string username);
        Task<SignInResult> Login(string username, string password);
    }
}
