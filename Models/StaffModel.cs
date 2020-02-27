using System.ComponentModel.DataAnnotations;

namespace SchoolDataBaseApp.Models
{
    public class StaffModel
    {
        [Key]
        public int StaffId { get; set; }

        [Display(Name ="Имя")]
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
        public int DepartamentId { get; set; }

        [Display(Name = "Специализация")]
        public int SpecializationId { get; set; }

    }
}
