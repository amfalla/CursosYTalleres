using ClasesYTalleres.Data;
using ClasesYTalleres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesYTalleres.Business
{
    public class CourseCategoryService : IDisposable
    {
        private IUnitOfWork unitOfWork;

        public IUnitOfWork UnitOfWork
        {
            get { return unitOfWork; }
        }
        
        public CourseCategoryService()
        {
            this.unitOfWork = new UnitOfWork();
        }

        public CourseCategoryService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<CourseCategory> GetCourseCategories()
        {
            var courseCategories = unitOfWork.CourseCategoryRepository.Get();
            return courseCategories.ToList();
        }

        public CourseCategory GetCourseCategoryByID(int id)
        {
            return unitOfWork.CourseCategoryRepository.GetByID(id);
        }

        public void InsertCourseCategory(CourseCategory courseCategory)
        {
            unitOfWork.CourseCategoryRepository.Insert(courseCategory);
            unitOfWork.Save();
        }

        public void DeleteCourseCategory(int courseCategoryID)
        {
            unitOfWork.CourseCategoryRepository.Delete(courseCategoryID);
            unitOfWork.Save();
        }

        public void UpdateCourseCategory(CourseCategory courseCategory)
        {
            unitOfWork.CourseCategoryRepository.Update(courseCategory);
            unitOfWork.Save();
        }

        public void Dispose()
        {
            unitOfWork.Dispose();
        }
    }
}
