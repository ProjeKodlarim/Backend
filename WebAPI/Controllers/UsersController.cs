using Business.Abstract;
using Business.Constants;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getbyuser")]
        public IActionResult GetById(string email)
        {
            var user = _userService.GetByMail(email);
            if (user!=null)
            {
                return Ok(user);
            }
            return BadRequest(Messages.userNotFound);
        }
    }
}
