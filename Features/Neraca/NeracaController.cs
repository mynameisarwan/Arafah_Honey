﻿using Arafah_Honey.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arafah_Honey.Features.Neraca
{
    [Route("api/[controller]")]
    [ApiController]
    public class NeracaController : ControllerBase
    {
        private readonly IMediator _mediator;

        public NeracaController(IMediator mediator) => _mediator = mediator;

        [HttpGet]
        public async Task<IEnumerable<Neracas>> GetNeracas() => await _mediator.Send(new GetNeraca.Query());
        [HttpGet("{id}")]
        public async Task<Neracas> GetNeraca(string id) => await _mediator.Send(new GetNeracaByID.Query { neraca_id = id });
        [HttpPost]
        public async Task<ActionResult> CreateNeraca([FromBody] AddNeraca.Command command) 
        {
            var GetNeracaId = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetNeraca), new { id = GetNeracaId }, null);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteNeraca(string id) {
            await _mediator.Send(new DeleteNeracaByID.Command { neraca_id = id });
            return CreatedAtAction(nameof(GetNeracas), null);
        }
        [HttpPut("{id}")]

        public async Task<ActionResult> UpdateNeraca(UpdateNeraca.UpdCommand command) 
        {
            var GetNeracaId = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetNeraca), new { id = GetNeracaId.neraca_id }, null);
        }
    }
}
