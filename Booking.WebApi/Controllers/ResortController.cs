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
        public IActionResult GetResorts()
        {
            var resorts = _resortService.List();

            if (resorts.ToList().Count == 0)
            {
                return NotFound(new { NotFoundError = "We stil do not have any resorts listed." });
            }

            return Ok(_mapper.Map<IEnumerable<ResortViewModel>>(resorts));
        }

        // GET: api/Resort/5
        [HttpGet("{id}")]
        public IActionResult GetResort(byte id)
        {
            var resort = _resortService.Get(id);

            if (resort == null)
            {
                return NotFound(new { NotFoundError = $"A resort with ID - {id} does not exist." });
            }

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
        public IActionResult UpdateResort(byte id, [FromBody] ResortViewModel resortViewModel)
        {
            resortViewModel.Id = id;

            var resort = _mapper.Map<Domain.Resort>(resortViewModel);

            _resortService.Update(resort);

            return Accepted(new { UpdatedInformation = resortViewModel });
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult DeleteResort(byte id)
        {
            _resortService.Delete(id);

            return Ok();
        }
    }
}
