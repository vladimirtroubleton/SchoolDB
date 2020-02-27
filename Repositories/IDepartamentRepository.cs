using SchoolDataBaseApp.Models;
using System.Collections.Generic;

namespace SchoolDataBaseApp.Repositories
{
    public interface IDepartamentRepository
    {
        void EditDepartamentRecord(DepartmentModel model);
        DepartmentModel FindDepartamentById(int id);
        List<DepartmentModel> GetAllDepartamentRecord();
        void RemoveDepartamentRecord(DepartmentModel model);
        void SaveNewDepartamentRecord(DepartmentModel model);
    }
}