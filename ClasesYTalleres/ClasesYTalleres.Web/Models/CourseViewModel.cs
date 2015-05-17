using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClasesYTalleres.Models
{
    public class CourseViewModel
    {
        public SelectList CategoriesList { get; set; }
        public SelectList LocationsList { get; set; }
        public SelectList ProfessorsList { get; set; }
        public Course Course { get; set; }
    }
}