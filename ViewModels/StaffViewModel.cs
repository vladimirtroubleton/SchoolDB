using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDataBaseApp.ViewModels
{
    public class StaffViewModel
    {
        [Display(Name = "Порядковый номер сотрудника")]
        public int Id { get; set; }

        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Display(Name = "Фамилия")]
        public string Surname { get; set; }

        [Display(Name = "Возраст")]
        public int Age { get; set; }

        [Display(Name = "Пол")]
        public string Gender { get; set; }

        [Display(Name = "Стаж работы")]
        public int ExperienceWork { get; set; }

        [Display(Name = "Название отдела")]
        public string DepartamentName { get; set; }

        [Display(Name = "Специализация")]
        public string Specialization { get; set; }
    }
}
