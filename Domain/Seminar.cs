using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Seminar
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Category { get; set; }

        public int AvailableSeats { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public DateTime DateTime { get; set; }
        
        [Required]
        public bool Active { get; set; }

        public string HostedBy { get; set; }

        public ICollection<UserSeminar> UserSeminars { get; set; }
    }
}
