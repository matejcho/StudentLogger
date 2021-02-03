using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLogger.Models
{
    public class EnrolledIn
    {
        public int EnrolledInID { get; set; }
        public virtual Student Student { get; set; }
        [Required]
        public int StudentID { get; set; }
        public virtual Course Course { get; set; }
        [Required]
        public int CourseID { get; set; }
    }
}
