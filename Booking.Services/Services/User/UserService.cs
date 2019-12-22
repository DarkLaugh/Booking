using AutoMapper;
using Booking.Data.Repository.User;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Services.Services.User
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _repository;

        public UserService(IMapper mapper, IUserRepository repository)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<string> Create(Domain.User user)
        {
            var entity = _mapper.Map<Data.Models.User>(user);

            return _repository.Create(entity);
        }

        public Task<SignInResult> Login(string username, string password)
        {
            return _repository.Login(username, password);
        }

        public Task<bool> UserExists(string username)
        {
            return _repository.UserExists(username);
        }
    }
}
