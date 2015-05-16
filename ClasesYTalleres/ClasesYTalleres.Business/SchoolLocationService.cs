using ClasesYTalleres.Data;
using ClasesYTalleres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesYTalleres.Business
{
    public class SchoolLocationService : IDisposable
    {
        private IUnitOfWork unitOfWork;

        public IUnitOfWork UnitOfWork
        {
            get { return unitOfWork; }
        }
        
        public SchoolLocationService()
        {
            this.unitOfWork = new UnitOfWork();
        }

        public SchoolLocationService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<SchoolLocation> GetSchoolLocations()
        {
            var schoolLocations = unitOfWork.SchoolLocationRepository.Get();
            return schoolLocations.ToList();
        }

        public SchoolLocation GetSchoolLocationByID(int id)
        {
            return unitOfWork.SchoolLocationRepository.GetByID(id);
        }

        public void InsertSchoolLocation(SchoolLocation schoolLocation)
        {
            unitOfWork.SchoolLocationRepository.Insert(schoolLocation);
            unitOfWork.Save();
        }

        public void DeleteSchoolLocation(int schoolLocationID)
        {
            unitOfWork.SchoolLocationRepository.Delete(schoolLocationID);
            unitOfWork.Save();
        }

        public void UpdateSchoolLocation(SchoolLocation schoolLocation)
        {
            unitOfWork.SchoolLocationRepository.Update(schoolLocation);
            unitOfWork.Save();
        }

        public void Dispose()
        {
            unitOfWork.Dispose();
        }
    }
}
