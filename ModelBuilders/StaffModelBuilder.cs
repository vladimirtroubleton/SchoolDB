using SchoolDataBaseApp.ViewModels;
using SchoolDataBaseApp.Models;
using SchoolDataBaseApp.Repositories;
using System.Collections.Generic;

namespace SchoolDataBaseApp.ModelBuilders
{
    public class StaffModelBuilder : IStaffModelBuilder
    {
        private readonly IStaffDataRepository staffDataRepository;
        private readonly IDepartamentRepository departamentRepository;
        private readonly ISpecializationStaffRepository specializationStaffRepository;

        public StaffModelBuilder(IStaffDataRepository staffDataRepository, IDepartamentRepository departamentRepository, ISpecializationStaffRepository specializationStaffRepository)
        {
            this.staffDataRepository = staffDataRepository;
            this.departamentRepository = departamentRepository;
            this.specializationStaffRepository = specializationStaffRepository;
        }

        public List<StaffViewModel> GetStaffInfo()
        {
            var modelList = staffDataRepository.GetAllStaffRecord();

            List<StaffViewModel> staffViews = new List<StaffViewModel>();

            foreach (var item in modelList)
            {
                staffViews.Add(new StaffViewModel
                {
                    Id = item.StaffId,
                    Name = item.Name,
                    Surname = item.Surname,
                    Age = item.Age,
                    ExperienceWork = item.ExperienceWork,
                    Gender = item.Gender,
                    DepartamentName = departamentRepository.FindDepartamentById(item.DepartamentId).DepartamentName,
                    Specialization = specializationStaffRepository.FindSpecializationById(item.SpecializationId).SpecializationName
                }
                );
            }

            return staffViews;
        }

        public StaffViewModel GetStaffInfoById(int id)
        {
           StaffModel model =  staffDataRepository.FindRecordById(id);

            return new StaffViewModel
            {
                Id = model.StaffId,
                Name = model.Name,
                Surname = model.Surname,
                Age = model.Age,
                Gender = model.Gender,
                ExperienceWork = model.ExperienceWork,
                DepartamentName = departamentRepository.FindDepartamentById(model.DepartamentId).DepartamentName,
                Specialization = specializationStaffRepository.FindSpecializationById(model.SpecializationId).SpecializationName

            };
        }
    }
}
