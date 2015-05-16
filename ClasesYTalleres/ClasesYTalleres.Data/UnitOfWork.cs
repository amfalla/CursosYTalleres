using ClasesYTalleres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesYTalleres.Data
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private CoursesClassesContext context = new CoursesClassesContext();
        private IGenericRepository<Course> courseRepository;
        private IGenericRepository<CourseCategory> courseCategoryRepository;
        private IGenericRepository<Professor> professorRepository;
        private IGenericRepository<SchoolLocation> schoolLocationRepository;
        private IGenericRepository<Institution> institutionRepository;
        private bool disposed = false;

        public IGenericRepository<Institution> InstitutionRepository
        {
            get
            {
                if (this.institutionRepository == null)
                {
                    this.institutionRepository = new GenericRepository<Institution>(context);
                }
                return institutionRepository;
            }
        }

        public IGenericRepository<SchoolLocation> SchoolLocationRepository
        {
            get
            {
                if (this.schoolLocationRepository == null)
                {
                    this.schoolLocationRepository = new GenericRepository<SchoolLocation>(context);
                }
                return schoolLocationRepository;
            }
        }

        public IGenericRepository<Professor> ProfessorRepository
        {
            get
            {
                if (this.professorRepository == null)
                {
                    this.professorRepository = new GenericRepository<Professor>(context);
                }
                return professorRepository;
            }
        }

        public IGenericRepository<Course> CourseRepository
        {
            get
            {
                if (this.courseRepository == null)
                {
                    this.courseRepository = new GenericRepository<Course>(context);
                }
                return courseRepository;
            }
        }

        public IGenericRepository<CourseCategory> CourseCategoryRepository
        {
            get
            {
                if (this.courseCategoryRepository == null)
                {
                    this.courseCategoryRepository = new GenericRepository<CourseCategory>(context);
                }
                return courseCategoryRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
