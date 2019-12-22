using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Booking.Domain;
using Microsoft.AspNetCore.Identity;

namespace Booking.Services.Services.User
{
    public interface IUserService
    {
        Task<string> Create(Domain.User user);
        Task<bool> UserExists(string username);
        Task<SignInResult> Login(string username, string password);
    }
}
