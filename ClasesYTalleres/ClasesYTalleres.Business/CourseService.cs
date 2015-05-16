using ClasesYTalleres.Data;
using ClasesYTalleres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesYTalleres.Business
{
    public class CoursesService : IDisposable
    {
        private IUnitOfWork unitOfWork;

        public IUnitOfWork UnitOfWork
        {
            get { return unitOfWork; }
        }
        
        public CoursesService()
        {
            this.unitOfWork = new UnitOfWork();
        }

        public CoursesService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Course> GetCourses()
        {
            var courses = unitOfWork.CourseRepository.Get();
            return courses.ToList();
        }

        public Course GetCourseByID(int id)
        {
            return unitOfWork.CourseRepository.GetByID(id);
        }

        public void InsertCourse(Course course)
        {
            unitOfWork.CourseRepository.Insert(course);
            unitOfWork.Save();
        }

        public void DeleteCourse(int courseID)
        {
            unitOfWork.CourseRepository.Delete(courseID);
            unitOfWork.Save();
        }

        public void UpdateCourse(Course course)
        {
            unitOfWork.CourseRepository.Update(course);
            unitOfWork.Save();
        }

        public void Dispose()
        {
            unitOfWork.Dispose();
        }
    }
}
