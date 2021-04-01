using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NJCSC.App.Repository.poc.Models
{
    public class EmpApplication
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ApplicationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
       
        public DateTime DateOfBirth { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }
        
        public DateTime CreatedDate { get; set; }
       
       
    }
}
