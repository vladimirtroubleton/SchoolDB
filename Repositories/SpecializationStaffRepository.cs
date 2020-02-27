using Microsoft.EntityFrameworkCore;
using SchoolDataBaseApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDataBaseApp.Repositories
{
    public class SpecializationStaffRepository : ISpecializationStaffRepository
    {
        DataContext dbcontext;

        public SpecializationStaffRepository(DataContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public void AddSpecializationRecord(SpecializationStaffModel model)
        {
            dbcontext.Specializations.Add(model);
            dbcontext.SaveChanges();
        }

        public List<SpecializationStaffModel> GetAllSpecializationRecord()
        {
            return dbcontext.Specializations.ToList();
        }

        public void RemoveSpecializationRecord(SpecializationStaffModel model)
        {
            dbcontext.Specializations.Remove(model);
            dbcontext.SaveChanges();
        }

        public void EditSpecializationRecord(SpecializationStaffModel model)
        {
            dbcontext.Entry(model).State = EntityState.Modified;
            dbcontext.SaveChanges();
        }

        public SpecializationStaffModel FindSpecializationById(int id)
        {
            return dbcontext.Specializations.Find(id);
        }

    }
}
