using AutoMapper;
using Booking.Data.Repository.User;
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
    }
}
