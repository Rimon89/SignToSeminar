using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Domain.ViewModels;
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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Seminar>>> Get()
        {
            var seminars = await _context.Seminars.ToListAsync();

            if (seminars == null)
                return NotFound();

            return Ok(seminars.OrderBy(date => date.DateTime));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Seminar>> Get(int id)
        {
            var seminar = await _context.Seminars.FindAsync(id);

            if (seminar == null)
                return NotFound();

            return Ok(seminar);
        }

        [HttpPost]
        public async Task<ActionResult<Seminar>> CreateSeminar(SeminarVM request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var seminar = new Seminar
            {
                Name = request.Name,
                Description = request.Description,
                Category = request.Category,
                AvailableSeats = request.AvailableSeats,
                Address = request.Address,
                City = request.City,
                DateTime = request.DateTime,
                Active = request.Active,
                HostedBy = request.HostedBy
            };

            await _context.Seminars.AddAsync(seminar);
            await _context.SaveChangesAsync();

            return Created($"api/seminars/{seminar.Id}", seminar);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Seminar>> Delete(int id)
        {
            var seminarToDelete = await _context.Seminars.FindAsync(id);

            if (seminarToDelete == null)
                return BadRequest("Error while deleting seminar");

           _context.Seminars.Remove(seminarToDelete);
           await _context.SaveChangesAsync();

            return Ok("Success deleting seminar");
        }
    }
}

