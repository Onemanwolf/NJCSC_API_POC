using NJCSC.App.Repository.poc.DTO;
using NJCSC.App.Repository.poc.Models;
using NJCSC.App.Repository.poc.Repository;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NJCSC.App.Service.poc.api.Serviices
{
    public class EmpApplicationService
    {
        private Repo _repo;


        public EmpApplicationService()
        {
            _repo = new Repo();
        }
        public async Task SaveEmpApplication(EmpApplicationDTO empApp)
        {
            var empApplicationToSave = MapToEmpApplication(empApp);


            await _repo.Save(empApplicationToSave);
        }

        public async Task<IEnumerable<EmpApplication>> GetAll()
        {
            var empApplications = await _repo.GetEmpApplications();

            return empApplications;


        }

        public async Task<EmpApplication> GetEmpApplicationById(int id)
        {
           return  await _repo.GetEmpApplicationById(id);
        }

        public async Task Delete(EmpApplicationDTO empApplication)
        {
            var empAppToDelete = MapToEmpApplication(empApplication);

            await _repo.Delete(empAppToDelete);
        }

        private EmpApplication MapToEmpApplication(EmpApplicationDTO empApplication)
        {

            var dateOfBirth = empApplication.DateOfBirth.ToShortDateString();
           
            DateTime parsedb;
            var dateOfBirthToSave = DateTime.TryParse(dateOfBirth, out parsedb);
           
            var stop = "stop";

            if(empApplication.CreatedDate == null)
            {
                empApplication.CreatedDate = DateTime.UtcNow;
            }



            return new EmpApplication
            {
                ApplicationId = empApplication.ApplicationId,
                FirstName = empApplication.FirstName,
                LastName = empApplication.LastName,
                EmailAddress = empApplication.EmailAddress,
                PhoneNumber = empApplication.PhoneNumber,
                DateOfBirth = parsedb,
                CreatedDate = empApplication.CreatedDate,

        };
        }

        public async Task Edit(EmpApplicationDTO empApplication)
        {
            var empAppToEdit = MapToEmpApplication(empApplication);
            await  _repo.Edit(empAppToEdit);
        }
    }
}
