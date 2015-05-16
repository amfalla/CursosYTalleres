using ClasesYTalleres.Data;
using ClasesYTalleres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesYTalleres.Business
{
    public class InstitutionService : IDisposable
    {
        private IUnitOfWork unitOfWork;

        public IUnitOfWork UnitOfWork
        {
            get { return unitOfWork; }
        }
        
        public InstitutionService()
        {
            this.unitOfWork = new UnitOfWork();
        }

        public InstitutionService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Institution> GetInstitutions()
        {
            var institutions = unitOfWork.InstitutionRepository.Get();
            return institutions.ToList();
        }

        public Institution GetInstitutionByID(int id)
        {
            return unitOfWork.InstitutionRepository.GetByID(id);
        }

        public void InsertInstitution(Institution institution)
        {
            unitOfWork.InstitutionRepository.Insert(institution);
            unitOfWork.Save();
        }

        public void DeleteInstitution(int institutionID)
        {
            unitOfWork.InstitutionRepository.Delete(institutionID);
            unitOfWork.Save();
        }

        public void UpdateInstitution(Institution institution)
        {
            unitOfWork.InstitutionRepository.Update(institution);
            unitOfWork.Save();
        }

        public void Dispose()
        {
            unitOfWork.Dispose();
        }
    }
}
