using ClasesYTalleres.Business;
using ClasesYTalleres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClasesYTalleres.Controllers.Search
{
    public class SearchController : Controller
    {
        private CoursesService courseService = new CoursesService();

        // GET: Search
        public ActionResult Search([Bind(Include="Keywords,Categories")] HomeViewModel model)
        {
            ViewBag.Prueba = model.Keywords;
            ViewBag.Prueba2 = model.Categories.SelectedValue;

            return View(courseService.GetCourses());
        }

        public ActionResult CourseProfile()
        {
            return View();
        }
    }
}