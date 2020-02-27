using SchoolDataBaseApp.Models;
using System.Collections.Generic;

namespace SchoolDataBaseApp.Repositories
{
    public interface IStaffDataRepository
    {
        void EditStaffRecord(StaffModel model);
        List<StaffModel> GetAllStaffRecord();
        void RemoveStaffRecord(StaffModel model);
        void SaveNewStaffRecord(StaffModel model);
        StaffModel FindRecordById(int? id);

        List<StaffModel> FindRecordByName(SearchModel model);
    }
}