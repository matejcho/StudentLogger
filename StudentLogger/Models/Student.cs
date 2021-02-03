using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLogger.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        [Display(Name = "Name or First Name")]
        [Required]
        public string Name { get; set; }
        [Display(Name ="Surname or Last Name")]
        [Required]
        public string Surname { get; set; }
        public DateTime StudentEnrolledDate { get; set; } = DateTime.Now;
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public byte[] Photo { get; set; }
    }
}
