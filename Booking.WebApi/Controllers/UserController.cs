using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Booking.WebApi.ViewModels;
using AutoMapper;
using Booking.Domain;
using Booking.Services.Services.User;

namespace Booking.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public UserController(IMapper mapper, IUserService userService)
        {
            _mapper = mapper;
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] UserViewModel userViewModel)
        {
            var user = _mapper.Map<User>(userViewModel);

            var result = await _userService.Create(user);

            if (result != null)
            {
                return Ok();
            }

            else
            {
                return BadRequest();
            }
        }
    }
}