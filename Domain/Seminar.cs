using System;
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

        public int availableSeats { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public DateTime DateTime { get; set; }
    }
}
