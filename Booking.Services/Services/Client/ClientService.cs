using System;
using System.Collections.Generic;
using System.Text;
using Booking.Domain;
using Booking.Data.Repository.Client;
using AutoMapper;

namespace Booking.Services.Services.Client
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _repository;
        private readonly IMapper _mapper;

        public ClientService(IClientRepository repository, IMapper mapper)
        {
            repository = _repository;
            mapper = _mapper;
        }
        
        public byte Create(Domain.Client client)
        {
            throw new NotImplementedException();
        }

        public void Delete(byte id)
        {
            throw new NotImplementedException();
        }

        public Domain.Client Get(byte id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Domain.Client> List()
        {
            var list = _repository.List();

            return _mapper.Map<IEnumerable<Domain.Client>>(list);
        }

        public void Update(Domain.Client client)
        {
            throw new NotImplementedException();
        }
    }
}
