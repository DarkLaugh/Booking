using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Booking.Services.Services.Resort;
using Booking.WebApi.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Booking.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResortController : ControllerBase
    {
        private readonly IResortService _resortService;
        private readonly IMapper _mapper;

        public ResortController(IResortService resortService, IMapper mapper)
        {
            _mapper = mapper;
            _resortService = resortService;
        }

        // GET: api/Resort
        [HttpGet]
        public IEnumerable<ResortViewModel> GetResorts()
        {
            var resorts = _resortService.List();

            return _mapper.Map<IEnumerable<ResortViewModel>>(resorts);
        }

        // GET: api/Resort/5
        [HttpGet("{id}")]
        public IActionResult GetResort(byte id)
        {
            var resort = _resortService.Get(id);
            var viewModel = _mapper.Map<ResortViewModel>(resort);

            return Ok(viewModel);
        }

        // POST: api/Resort
        [HttpPost]
        public ResortViewModel CreateResort([FromBody] ResortViewModel resortViewModel)
        {
            var resort = _mapper.Map<Domain.Resort>(resortViewModel);

            _resortService.Create(resort);

            return _mapper.Map<ResortViewModel>(resort);
        }

        // PUT: api/Resort/5
        [HttpPut("{id}")]
        public void UpdateResort(byte id, [FromBody] ResortViewModel resortViewModel)
        {
            resortViewModel.Id = id;

            var resort = _mapper.Map<Domain.Resort>(resortViewModel);

            _resortService.Update(resort);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void DeleteResort(byte id)
        {
            _resortService.Delete(id);
        }
    }
}
