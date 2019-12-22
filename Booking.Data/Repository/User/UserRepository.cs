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
        private readonly SignInManager<Models.User> _signInManager;

        public UserRepository(UserManager<Models.User> userManager, SignInManager<Models.User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }


        public async Task<string> Create(Models.User user)
        {
            await _userManager.CreateAsync(user, user.Password);

            return user.Id;
        }

        public async Task<bool> UserExists(string username)
        {
            var user = await _userManager.FindByNameAsync(username);

            if (user != null)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public async Task<SignInResult> Login(string username, string password)
        {
            var user = await _userManager.FindByNameAsync(username);

            if (user != null)
            {
                var signInResult = await _signInManager.PasswordSignInAsync(user, password, false, false);

                return signInResult;
            }

            else
            {
                return SignInResult.Failed;
            }
        }
    }
}
