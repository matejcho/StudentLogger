using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLogger.Models
{
    public class AcademicYear
    {
        public int AcademicYearID { get; set; }
        [Required]
        public string Year { get; set; }
    }
}
