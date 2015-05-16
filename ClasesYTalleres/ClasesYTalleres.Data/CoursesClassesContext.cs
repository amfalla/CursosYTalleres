using ClasesYTalleres.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesYTalleres.Data
{
    public class CoursesClassesContext : DbContext
    {
        public CoursesClassesContext() : base("DefaultConnection")
        {
            
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseCategory> CourseCategories { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<SchoolLocation> SchoolLocations { get; set; }
    }
}
