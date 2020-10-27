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

            if (seminar == null || seminar.AvailableSeats <= 0)
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
                seminar.AvailableSeats = seminar.AvailableSeats - 1;
                await _context.SaveChangesAsync();

                return Ok();
            }

            var attendee = new UserSeminar
            {
                Seminar = seminar,
                User = userFromDb,
                DateSignUp = DateTime.Now
            };

            var userSeminar = _context.UserSeminars.FirstOrDefault(x => x.Seminar == attendee.Seminar && x.User == attendee.User);

            if (userSeminar == null)
            {
                _context.UserSeminars.Add(attendee);
                seminar.AvailableSeats = seminar.AvailableSeats - 1;
                await _context.SaveChangesAsync();
                return Ok();
            }

            return BadRequest("You have already signed up for this seminar");
        }
    }
}
