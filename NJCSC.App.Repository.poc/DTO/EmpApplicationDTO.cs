using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NJCSC.App.Repository.poc.DTO
{
    public class EmpApplicationDTO
    {
        public int ApplicationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }
      
        public DateTime CreatedDate { get; set; }
    }
}
