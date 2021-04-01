using NJCSC.App.Repository.poc.Models;
using System.Data.Entity;

namespace NJCSC.App.Repository.poc.Repository
{
    public class EmpApplicationContext : DbContext
    {


        public DbSet<EmpApplication> EmpApplications { get; set; }

    }
}
