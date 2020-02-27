using System.Collections.Generic;
using SchoolDataBaseApp.ViewModels;

namespace SchoolDataBaseApp.ModelBuilders
{
    public interface IStaffModelBuilder
    {
        List<StaffViewModel> GetStaffInfo();
        StaffViewModel GetStaffInfoById(int id);
    }
}