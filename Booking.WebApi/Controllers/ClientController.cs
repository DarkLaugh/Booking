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

namespace Booking.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IMapper _mapper;

        public ClientController(IMapper mapper, IMemoryCache cache)
        {
            _mapper = mapper;
        }
        
        // GET: api/Client
        [HttpGet]
        public List<Client> GetClients()
        {
            List<Client> clients = GetAllClients();

            return clients;
        }

        // GET: api/Client/5
        [HttpGet("{id}", Name = "Get")]
        public Client GetClient(uint id)
        {
            var client = GetAllClients().SingleOrDefault(c => c.Id == id);

            return client;
        }

        // POST: api/Client
        [HttpPost]
        public IActionResult CreateClient([FromBody] ClientViewModel client)
        {
            List<ClientViewModel> clients = new List<ClientViewModel>();

            _mapper.Map(GetAllClients(), clients);

            clients.Add(client);

            return Ok(clients);
        }

        // PUT: api/Client/5
        [HttpPut("{id}")]
        public IActionResult UpdateClient(int id, [FromBody] ClientViewModel clientViewModel)
        {
            List<Client> clients = GetAllClients();

            Client clientInList = clients.SingleOrDefault(c => c.Id == id);

            _mapper.Map(clientViewModel, clientInList);

            return Ok(clients);

        }

        // DELETE: api/Client/5
        [HttpDelete("{id}")]
        public IActionResult DeleteClient(int id)
        {
            List<Client> clients = GetAllClients();

            var client = GetAllClients().SingleOrDefault(c => c.Id == id);

            clients.Remove(client);

            return Ok(clients);
        }


        private List<Client> GetAllClients()
        {
            List<Client> _clients = new List<Client>
            {
                new Client
                {
                   Id = 1,
                   FirstName = "John",
                   LastName = "Richards",
                   Age = 29
                },

                new Client
                {
                    Id = 2,
                    FirstName = "Mary",
                    LastName= "Morningstar",
                    Age = 30
                }
            };

            return _clients;
        }

    }
}
