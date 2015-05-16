using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesYTalleres.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public int Price { get; set; }
        public string ImageURL { get; set; }
        public bool HasCertification { get; set; }
        public string CertificationName { get; set; }
        public string CertificationInstitution { get; set; }

        public virtual Institution Institution { get; set; }
        public virtual CourseCategory Category { get; set; }
        public virtual Professor Professor { get; set; }
        public virtual SchoolLocation Location { get; set; } 
    }
}
