﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NJCSC.App.Repository.poc.Models
{
    public class Address
    {
       
        [Key]
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PostalCode { get; set; }
        
    }
}
