using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClasesYTalleres.Models
{
    public class CourseViewModel
    {
        public List<CourseCategory> Categories { get; set; }
        public SelectList Locations { get; set; }
        public SelectList Professors { get; set; }
        public Course Course { get; set; }
    }
}