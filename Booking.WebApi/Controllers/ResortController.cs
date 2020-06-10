using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Booking.Services.Services.Resort;
using Booking.WebApi.ViewModels;
using Microsoft.AspNetCore.Hosting;
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
        private readonly IWebHostEnvironment _env;

        public ResortController(IResortService resortService, IMapper mapper, IWebHostEnvironment env)
        {
            _mapper = mapper;
            _resortService = resortService;
            _env = env;
        }

        // GET: api/Resort
        [HttpGet]
        public IActionResult GetResorts()
        {
            var resorts = _resortService.List();

            if (resorts.ToList().Count == 0)
            {
                return NotFound(new { errorMessage = "We still do not have any resorts listed." });
            }

            return Ok(_mapper.Map<IEnumerable<ResortGetViewModel>>(resorts));
        }

        // GET: api/Resort/5
        [HttpGet("{id}")]
        public IActionResult GetResort(byte id)
        {
            var resort = _resortService.Get(id);

            if (resort == null)
            {
                return NotFound(new { errorMessage = $"A resort with ID - {id} does not exist." });
            }

            var viewModel = _mapper.Map<ResortGetViewModel>(resort);

            return Ok(viewModel);
        }

        // POST: api/Resort
        [HttpPost]
        public async Task<ResortGetViewModel> CreateResort([FromForm] ResortViewModel resortViewModel)
        {
            if (resortViewModel.Thumbnail != null)
            {
                await _resortService.UploadThumbnail(resortViewModel.Thumbnail, resortViewModel.Thumbnail.FileName, resortViewModel.Name);
            }

            var resort = _mapper.Map<Domain.Resort>(resortViewModel);

            _resortService.Create(resort);

            return _mapper.Map<ResortGetViewModel>(resort);
        }

        // PUT: api/Resort/5
        [HttpPut("{ id}")]
        public IActionResult UpdateResort(byte id, [FromBody] ResortViewModel resortViewModel)
        {
            resortViewModel.Id = id;

            var resort = _mapper.Map<Domain.Resort>(resortViewModel);

            _resortService.Update(resort);

            return Accepted(new { UpdatedInformation = resortViewModel });
        }

        // DELETE: api/Resort/5
        [HttpDelete("{id}")]
        public IActionResult DeleteResort(byte id)
        {
            _resortService.Delete(id);

            return Ok();
        }
    }
}
