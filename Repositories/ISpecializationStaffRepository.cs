using SchoolDataBaseApp.Models;
using System.Collections.Generic;

namespace SchoolDataBaseApp.Repositories
{
    public interface ISpecializationStaffRepository
    {
        void AddSpecializationRecord(SpecializationStaffModel model);
        void EditSpecializationRecord(SpecializationStaffModel model);
        SpecializationStaffModel FindSpecializationById(int id);
        List<SpecializationStaffModel> GetAllSpecializationRecord();
        void RemoveSpecializationRecord(SpecializationStaffModel model);
    }
}