using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MVCTestApp.Models
{
    /// <summary>
    /// Course Information
    /// </summary>
    public class Course
    {
        [Key]
        public int SectionID { get; set; }
        [Required][StringLength(6,ErrorMessage = "CourseID must begin with 3 letters and end with 3 numbers.",MinimumLength =6)]
        public string CourseID { get; set; }
        [Required]
        public string CourseName { get; set; }
        [Required][DisplayFormat(DataFormatString = "{0:hh:mm tt}",
               ApplyFormatInEditMode = true)]
        public DateTime ClassStartTime { get; set; }
        [Required][DisplayFormat(DataFormatString = "{0:hh:mm tt}",
               ApplyFormatInEditMode = true)]
        public DateTime ClassEndTime { get; set; }

        [Required][DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}",
               ApplyFormatInEditMode = true)]
        public DateTime CourseStartDate { get; set; }
        [Required][DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}",
               ApplyFormatInEditMode = true)]
        public DateTime CourseEndDate { get; set; }
        [Required]
        public byte CourseHours { get; set; }
    }

    public class CoursesDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
    }
}