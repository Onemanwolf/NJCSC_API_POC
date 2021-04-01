using Newtonsoft.Json;
using NJCSC.App.Repository.poc.DTO;
using NJCSC.App.Repository.poc.Models;

using NJCSC.App.Service.poc.api.Serviices;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace NJCSC.App.Service.poc.api.Controllers
{
    public class EmploymentApplicatonController : ApiController
    {

        private IEmpApplicationService _service;
        
        public EmploymentApplicatonController(IEmpApplicationService service)
        {
            _service = service;
        }

       

        // GET api/EmploymentApplicaton
        public async Task<IEnumerable<EmpApplication>> Get()
        {
            var empApp = await _service.GetAll();
            return empApp;
        }

       
        // GET api/EmploymentApplicaton/5
        public async Task<EmpApplication> Get(int id)
        {
          return await  _service.GetEmpApplicationById(id);
        }

        // POST api/values
        public async Task Post([FromBody] EmpApplicationDTO empApplication)
        { 
                      
         await _service.SaveEmpApplication(empApplication);

        }

        // PUT api/EmploymentApplicaton/5
        [HttpPut]
        public async Task Put(int id, EmpApplicationDTO empApplicationJson)
        {
           // var data = JsonConvert.DeserializeObject<EmpApplicationDTO>(empApplicationJson);
            await _service.Edit(empApplicationJson);

        }

        // DELETE api/EmploymentApplicaton/5
        public async Task Delete([FromBody] EmpApplicationDTO empApplication)
        {
          await  _service.Delete(empApplication);

        }
    }
}
