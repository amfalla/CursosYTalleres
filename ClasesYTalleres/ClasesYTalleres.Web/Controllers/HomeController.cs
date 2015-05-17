using ClasesYTalleres.Business;
using ClasesYTalleres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClasesYTalleres.Controllers
{
    public class HomeController : Controller
    {
        private CourseCategoryService courseCategoryservice = new CourseCategoryService();

        public ActionResult Index()
        {
            var model = new HomeViewModel();
            model.Categories.DropDownList = new SelectList(courseCategoryservice.GetCourseCategories(), "Id", "Name");

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}