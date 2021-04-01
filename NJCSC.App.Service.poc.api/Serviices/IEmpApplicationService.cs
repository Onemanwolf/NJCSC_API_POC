using NJCSC.App.Repository.poc.DTO;
using NJCSC.App.Repository.poc.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NJCSC.App.Service.poc.api.Serviices
{
    public interface IEmpApplicationService
    {
        Task Delete(EmpApplicationDTO empApplication);
        Task Edit(EmpApplicationDTO empApplication);
        Task<IEnumerable<EmpApplication>> GetAll();
        Task<EmpApplication> GetEmpApplicationById(int id);
        Task SaveEmpApplication(EmpApplicationDTO empApp);
    }
}