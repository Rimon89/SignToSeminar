using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class UserSeminar
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int SeminarId { get; set; }
        public Seminar Seminar { get; set; }
        public DateTime DateSignUp { get; set; }
    }
}
