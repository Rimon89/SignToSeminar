using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Seminars;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace SignToSeminar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeminarsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SeminarsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET api/seminars
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Seminar>>> Get()
        {
            return await _mediator.Send(new List.Query());
        }

        // GET api/seminar/5
        [HttpGet("{id}")]
        public void Get(int id)
        {

        }

        // POST api/seminars
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/seminars/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/seminars/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

