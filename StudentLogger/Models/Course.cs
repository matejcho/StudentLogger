using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLogger.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Professor { get; set; }
        [ForeignKey("AcademicYearID")]
        public virtual AcademicYear AcademicYear { get; set; }
        [Required]
        public int AcademicYearID { get; set; }
        //public ICollection<Student> EnrolledStudents { get; set; }
    }
}
