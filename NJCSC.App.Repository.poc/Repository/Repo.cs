using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using NJCSC.App.Repository.poc.Models;
using System;
using NJCSC.App.Repository.poc.DTO;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;

namespace NJCSC.App.Repository.poc.Repository
{
    public class Repo
    {
        private EmpApplicationContext _db;

        public Repo()
        {
            _db = new EmpApplicationContext();      
        }

        public async Task Save(EmpApplication empApplication)
        {

            if (empApplication.CreatedDate == DateTime.MinValue)
            {
                empApplication.CreatedDate = DateTime.UtcNow;
            }

            _db.Database.Log = Console.WriteLine;
            _db.EmpApplications.Add(empApplication);

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {

                Debug.WriteLine(ex);
            }
        }


        public async Task<IEnumerable<EmpApplication>> GetEmpApplications()
        {
            var empApp = await (from ea in _db.EmpApplications
                                orderby ea.ApplicationId
                                select ea).ToListAsync();

           
            return empApp;
        }


        public async Task<EmpApplication> GetEmpApplicationById(int id)
        {
            var empApp = await (from ea in _db.EmpApplications
                                where ea.ApplicationId == id
                                select ea).FirstAsync();
            return empApp;
        }

        public async Task Delete(EmpApplication empApplication)
        {
            var empApp = await (from ea in _db.EmpApplications
                                where ea.ApplicationId == empApplication.ApplicationId
                                select ea).FirstAsync();
            _db.EmpApplications.Remove(empApp);
            await _db.SaveChangesAsync();
        }

        public async Task Edit(EmpApplication empApplication)
        {

            if(empApplication.CreatedDate == DateTime.MinValue)
            {
                empApplication.CreatedDate = DateTime.UtcNow;
            }


            _db.Entry(empApplication).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch(DbUpdateException ex)
            {
                Debug.WriteLine(ex);
            }
           
        }
    }
}
