using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.ViewModels
{
    public class SeminarVM
    {
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
    }
}
