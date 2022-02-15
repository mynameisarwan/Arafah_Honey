using Arafah_Honey.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arafah_Honey.Features.Users
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator) => _mediator = mediator;
        [HttpPost]
        public async Task<ActionResult> GetUser([FromBody] GetUser.UserAuthCommand command) {
            var getAuth = await _mediator.Send(command);
            return Ok(getAuth);
            //return CreatedAtAction(nameof(getAuth), new { id = getAuth.UserId }, null);
        }
    }
}
