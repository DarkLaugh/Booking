using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Booking.Domain;
using Booking.WebApi.ViewModels;
using AutoMapper;
using Microsoft.Extensions.Caching.Memory;
using FluentValidation;
using FluentValidation.AspNetCore;
using Booking.WebApi.Validation;
using Booking.Services.Services.Client;

namespace Booking.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;
        private readonly IMapper _mapper;

        public ClientController(IMapper mapper, IClientService clientService)
        {
            _mapper = mapper;
            _clientService = clientService;
        }

        // GET: api/Client
        [HttpGet]
        public IEnumerable<ClientViewModel> GetClients()
        {
            var clients = _clientService.List();

            return _mapper.Map<IEnumerable<ClientViewModel>>(clients);
        }

        // GET: api/Client/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult GetClient(byte id)
        {
            var client = _clientService.Get(id);
            var viewModel = _mapper.Map<ClientViewModel>(client);

            return Ok(viewModel);
        }

        // POST: api/Client
        [HttpPost]
        public ClientViewModel CreateClient([FromBody] ClientViewModel viewModel)
        {
            var client = _mapper.Map<Client>(viewModel);

            _clientService.Create(client);

            return _mapper.Map<ClientViewModel>(client);
        }

        // PUT: api/Client/5
        [HttpPut("{id}")]
        public void UpdateClient(byte id, [FromBody] ClientViewModel clientViewModel)
        {
            clientViewModel.Id = id;

            var client = _mapper.Map<Client>(clientViewModel);

            _clientService.Update(client);

        }

        // DELETE: api/Client/5
        [HttpDelete("{id}")]
        public void DeleteClient(byte id)
        {
            _clientService.Delete(id);
        }
    }
}
