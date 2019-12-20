using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using Booking.Data.Models;
using System.Threading.Tasks;

namespace Booking.Data.Repository.User
{
    internal class UserRepository : IUserRepository
    {
        private readonly UserManager<Models.User> _userManager;

        public UserRepository(UserManager<Models.User> userManager)
        {
            _userManager = userManager;
        }


        public async Task<string> Create(Models.User user)
        {
            await _userManager.CreateAsync(user, user.Password);

            return user.Id;
        }
    }
}
