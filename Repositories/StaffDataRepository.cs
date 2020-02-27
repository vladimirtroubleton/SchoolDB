using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using SchoolDataBaseApp.Repositories;
using SchoolDataBaseApp.Models;

namespace SchoolDataBaseApp.Repositories
{
    public class StaffDataRepository : IStaffDataRepository
    {
        public DataContext dbcontext;

        public StaffDataRepository(DataContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public void SaveNewStaffRecord(StaffModel model)
        {
            dbcontext.Staffs.Add(model);
            dbcontext.SaveChanges();
        }

        public List<StaffModel> GetAllStaffRecord()
        {
            return dbcontext.Staffs.ToList();
        }

        public void RemoveStaffRecord(StaffModel model)
        {
            dbcontext.Staffs.Remove(model);
            dbcontext.SaveChanges();
        }

        public void EditStaffRecord(StaffModel model)
        {
            dbcontext.Entry(model).State = EntityState.Modified;
            dbcontext.SaveChanges();
        }

        public StaffModel FindRecordById(int? id)
        {
            return dbcontext.Staffs.Find(id);
        }

        public List<StaffModel> FindRecordByName(SearchModel model)
        {
            return dbcontext.Staffs.Where(x=> x.Name == model.Name && x.Surname == model.Surname).ToList();
        }
    }


}
