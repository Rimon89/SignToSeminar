using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace SignToSeminar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeminarsController : ControllerBase
    {
        private readonly DataContext _context;

        public SeminarsController(DataContext context)
        {
            _context = context;
        }

        // GET api/seminars
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Seminar>>> Get()
        {
            var seminars = await _context.Seminars.ToListAsync();
            return Ok(seminars);
        }

        // GET api/seminar/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Seminar>> Get(int id)
        {
            var seminar = await _context.Seminars.FindAsync(id);
            return Ok(seminar);
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

