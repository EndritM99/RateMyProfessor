﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RateForProfessor.Models
{
    public class Professor
    {
        [Key] 
        public int ProfessorId { get; set; } 

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Education { get; set; }

        public string Role { get; set; }


    }
}