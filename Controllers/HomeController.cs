
using SchoolDataBaseApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolDataBaseApp.Models;
using SchoolDataBaseApp.Repositories;
using System.Linq;
using SchoolDataBaseApp.ModelBuilders;
using System.Collections.Generic;

namespace SchoolDataBaseApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDepartamentRepository departamentRepository;
        private readonly IStaffDataRepository staffDataRepository;
        private readonly IStaffModelBuilder staffModelBuilder;
        private readonly ISpecializationStaffRepository specializationStaffRepository;

        public HomeController(IDepartamentRepository departamentRepository, IStaffDataRepository staffDataRepository, IStaffModelBuilder staffModelBuilder, ISpecializationStaffRepository specializationStaffRepository)
        {
            this.departamentRepository = departamentRepository;
            this.staffDataRepository = staffDataRepository;
            this.staffModelBuilder = staffModelBuilder;
            this.specializationStaffRepository = specializationStaffRepository;
        }

        public IActionResult Index()
        {
            return View(staffModelBuilder.GetStaffInfo().OrderBy(x => x.Name).ToList());
        }

        public IActionResult LookSpecialization()
        {

            return View(specializationStaffRepository.GetAllSpecializationRecord());
        } 

        public IActionResult LookDepartamentsData()
        {
            return View(departamentRepository.GetAllDepartamentRecord());
        }

       [HttpGet]
       public IActionResult AddStaffRecord()
       {
            ViewBag.Departaments = departamentRepository.GetAllDepartamentRecord();
            ViewBag.Specialization = specializationStaffRepository.GetAllSpecializationRecord();

            return View();
       }

        [HttpPost]
        public IActionResult AddStaffRecord(StaffModel model)
        {
            staffDataRepository.SaveNewStaffRecord(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddSpecializationRecord()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSpecializationRecord(SpecializationStaffModel model)
        {
            specializationStaffRepository.AddSpecializationRecord(model);
            return RedirectToAction("LookSpecialization");
        }

        [HttpGet]
        public IActionResult AddDepartamentRecord()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDepartamentRecord(DepartmentModel model)
        {
            departamentRepository.SaveNewDepartamentRecord(model);
            return RedirectToAction("LookDepartamentsData");
        }

        [HttpGet]
        public IActionResult StaffRecordEdit(int id)
        {
            ViewBag.Departaments = departamentRepository.GetAllDepartamentRecord();
            ViewBag.Specialization = specializationStaffRepository.GetAllSpecializationRecord();

            return View(staffDataRepository.FindRecordById(id));
        }

        [HttpPost]

        public IActionResult StaffRecordEdit(StaffModel model)
        {
            staffDataRepository.EditStaffRecord(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult StaffRecordRemove(int id)
        {
            return View(staffModelBuilder.GetStaffInfoById(id));
        }

        [HttpPost]
        public IActionResult StaffRecordRemove(StaffViewModel model)
        {
            var removableModel = staffDataRepository.FindRecordById(model.Id);

            staffDataRepository.RemoveStaffRecord(removableModel);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult SearchStaff()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchStaff(SearchModel model)
        {
            var recordsToView = new List<StaffViewModel>();
            var recordsByDb = staffDataRepository.FindRecordByName(model);
            foreach(var record in recordsByDb)
            {
                recordsToView.Add(staffModelBuilder.GetStaffInfoById(record.StaffId));
            }
            return View("SearchedData",recordsToView);
        }
        [HttpGet]
        public IActionResult GetExperiencePeople()
        {
            return View(staffModelBuilder.GetStaffInfo().OrderByDescending(x => x.ExperienceWork).ToList());
        }
    }
}
