using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ClasesYTalleres.Models;
using ClasesYTalleres.Business;

namespace ClasesYTalleres.Controllers.Institutions
{
    public class CoursesController : Controller
    {
        private CoursesService courseService = new CoursesService();

        // GET: Courses
        public ActionResult Index()
        {
            return View(courseService.GetCourses());
        }

        // GET: Courses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            Course course = courseService.GetCourseByID(id.Value);
            
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // GET: Courses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Courses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description,Content,Price,ImageURL,HasCertification,CertificationName,CertificationInstitution,Category,Location,Professor")] Course course)
        {
            if (ModelState.IsValid)
            {
                courseService.InsertCourse(course);
                return RedirectToAction("Index");
            }

            var model = new CourseViewModel();
            model.Course = course;

            return View(model);
        }

        // GET: Courses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Course course = courseService.GetCourseByID(id.Value);
            
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // POST: Courses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description,Content,Price,ImageURL,HasCertification,CertificationName,CertificationInstitution,Category,Location,Professor")] Course course)
        {
            if (ModelState.IsValid)
            {
                courseService.UpdateCourse(course);
                return RedirectToAction("Index");
            }
            return View(course);
        }

        // GET: Courses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Course course = courseService.GetCourseByID(id.Value);
            
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // POST: Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            courseService.DeleteCourse(id);
            
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            courseService.Dispose();
            base.Dispose(disposing);
        }
    }
}
