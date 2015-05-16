using ClasesYTalleres.Data;
using ClasesYTalleres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesYTalleres.Business
{
    public class ProfessorService : IDisposable
    {
        private IUnitOfWork unitOfWork;

        public IUnitOfWork UnitOfWork
        {
            get { return unitOfWork; }
        }
        
        public ProfessorService()
        {
            this.unitOfWork = new UnitOfWork();
        }

        public ProfessorService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Professor> GetProfessors()
        {
            var professors = unitOfWork.ProfessorRepository.Get();
            return professors.ToList();
        }

        public Professor GetProfessorByID(int id)
        {
            return unitOfWork.ProfessorRepository.GetByID(id);
        }

        public void InsertProfessor(Professor professor)
        {
            unitOfWork.ProfessorRepository.Insert(professor);
            unitOfWork.Save();
        }

        public void DeleteProfessor(int professorID)
        {
            unitOfWork.ProfessorRepository.Delete(professorID);
            unitOfWork.Save();
        }

        public void UpdateProfessor(Professor professor)
        {
            unitOfWork.ProfessorRepository.Update(professor);
            unitOfWork.Save();
        }

        public void Dispose()
        {
            unitOfWork.Dispose();
        }
    }
}
