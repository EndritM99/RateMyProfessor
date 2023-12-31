﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RateForProfessor.Entities
{
    public class ProfessorCourseEntity
    {

        [Key]
        public int ProfessorCourseId { get; set; }

        [ForeignKey("Professor")]
        public int ProfessorId { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }

        public virtual ProfessorEntity Professor { get; set; }

        public virtual CourseEntity Courses { get; set; }
    }
}

