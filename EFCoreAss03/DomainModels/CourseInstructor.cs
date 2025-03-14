using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFCoreAss03.DomainModels
{
    internal class CourseInstructor
    {
        
        [Key, Column(Order = 0)] // Composite Primary Key (Part 1)
        public int CourseId { get; set; }

        [Key, Column(Order = 1)] // Composite Primary Key (Part 2)
        public int InstructorId { get; set; }

        [ForeignKey("CourseId")]
        public Course Course { get; set; }

        [ForeignKey("InstructorId")]
        public Instructor Instructor { get; set; }

        public double Evaluate { get; set; } // Additional attribute
      

}
}
