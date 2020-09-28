using System.Collections.Generic;
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

            if (seminars == null)
                return NotFound();

            return Ok(seminars);
        }
    }
}

