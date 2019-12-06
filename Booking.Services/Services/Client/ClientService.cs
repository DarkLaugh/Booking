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
            _repository = repository;
            _mapper = mapper;
        }
        
        public byte Create(Booking.Domain.Client client)
        {
            var entity = _mapper.Map<Data.Models.Client>(client);

            return _repository.Create(entity);
        }

        public void Delete(byte id)
        {
            _repository.Detele(id);
        }

        public Domain.Client Get(byte id)
        {
            var client = _repository.Get(id);

            return _mapper.Map<Domain.Client>(client);
        }

        public IEnumerable<Domain.Client> List()
        {
            var list = _repository.List();

            return _mapper.Map<IEnumerable<Domain.Client>>(list);
        }

        public void Update(Domain.Client client)
        {
            var entity = _mapper.Map<Data.Models.Client>(client);

            _repository.Update(entity);
        }
    }
}
