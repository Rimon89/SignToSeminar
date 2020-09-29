using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Persistence;

namespace SignToSeminar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserVM request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var userFromDb = _context.Users.SingleOrDefault(u => u.Email == request.Email);
            var seminar = await _context.Seminars.FindAsync(request.seminarId);

            if (seminar == null)
                return BadRequest();

            if (userFromDb == null)
            {
                var user = new User
                {
                    Firstname = request.Firstname,
                    Lastname = request.Lastname,
                    Email = request.Email,
                    PhoneNumber = request.PhoneNumber,
                    City = request.City,
                    Address = request.Address
                };

                await _context.Users.AddAsync(user);

                var newAttendee = new UserSeminar
                {
                    Seminar = seminar,
                    User = user,
                    DateSignUp = DateTime.Now
                };

                await _context.UserSeminars.AddAsync(newAttendee);

                await _context.SaveChangesAsync();

                return Ok();
            }

            try
            {
                var attendee = new UserSeminar
                {
                    Seminar = seminar,
                    User = userFromDb,
                    DateSignUp = DateTime.Now
                };

                _context.UserSeminars.Add(attendee);

                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return BadRequest("You have already signed up for this seminar");
            }

            return Ok();
        }
    }
}
