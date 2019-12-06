using AutoMapper;
using Booking.Data.Repository.Resorts;
using Booking.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Services.Services.Resort
{
    public class ResortService : IResortService
    {
        private readonly IResortRepository _repository;
        private readonly IMapper _mapper;

        public ResortService(IResortRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public byte Create(Domain.Resort resort)
        {
            var entity = _mapper.Map<Data.Models.Resort>(resort);

            return _repository.Create(entity);
        }

        public void Delete(byte id)
        {
            _repository.Delete(id);
        }

        public Domain.Resort Get(byte id)
        {
            var resort = _repository.Get(id);

            return _mapper.Map<Domain.Resort>(resort);
        }

        public IEnumerable<Domain.Resort> List()
        {
            var list = _repository.List();

            return _mapper.Map<IEnumerable<Domain.Resort>>(list);
        }

        public void Update(Domain.Resort resort)
        {
            var entity = _mapper.Map<Data.Models.Resort>(resort);

            _repository.Update(entity);
        }
    }
}
