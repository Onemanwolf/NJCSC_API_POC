using NJCSC.App.Repository.poc.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NJCSC.App.Repository.poc.Repository
{
    public interface IRepo
    {
        Task Delete(EmpApplication empApplication);
        Task Edit(EmpApplication empApplication);
        Task<EmpApplication> GetEmpApplicationById(int id);
        Task<IEnumerable<EmpApplication>> GetEmpApplications();
        Task Save(EmpApplication empApplication);
    }
}