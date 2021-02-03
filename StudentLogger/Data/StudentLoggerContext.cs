using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentLogger.Models;

namespace StudentLogger.Data
{
    public class StudentLoggerContext : DbContext
    {
        public StudentLoggerContext (DbContextOptions<StudentLoggerContext> options)
            : base(options)
        {
        }

        public DbSet<StudentLogger.Models.AcademicYear> AcademicYear { get; set; }

        public DbSet<StudentLogger.Models.Student> Student { get; set; }

        public DbSet<StudentLogger.Models.Course> Course { get; set; }

        public DbSet<StudentLogger.Models.EnrolledIn> EnrolledIn { get; set; }
    }
}
