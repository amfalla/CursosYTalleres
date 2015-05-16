using ClasesYTalleres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesYTalleres.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Course> CourseRepository { get; }
        IGenericRepository<CourseCategory> CourseCategoryRepository { get; }
        IGenericRepository<Professor> ProfessorRepository { get; }
        IGenericRepository<SchoolLocation> SchoolLocationRepository { get; }
        IGenericRepository<Institution> InstitutionRepository { get; }
        void Save();
    }
}
