﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Owleet.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Money { get; set; }
        public int Rating { get; set; }
        public DateTime DateRegister { get; set; }
        public virtual ICollection<Test> Tests { get; set; }
        public virtual ICollection<UserAnswer> UserAnswers { get; set; }
        public virtual ICollection<Tournament> Tournaments { get; set; }
        public ApplicationUser()
        {
            Tests = new HashSet<Test>();
            UserAnswers = new HashSet<UserAnswer>();
            Tournaments = new HashSet<Tournament>();
        }
    }
    
}
