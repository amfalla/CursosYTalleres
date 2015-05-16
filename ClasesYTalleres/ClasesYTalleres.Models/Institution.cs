using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesYTalleres.Models
{
    public class Institution
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SchoolLocation> Locations { get; set; }
        public List<Professor> Professors { get; set; }
        public List<Course> Courses { get; set; }
    }
}
