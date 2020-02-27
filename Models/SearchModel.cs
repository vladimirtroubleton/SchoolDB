using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDataBaseApp.Models
{
    public class SearchModel
    {
        [Display(Name = "Введите имя")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Введите Фамилию")]
        [Required]
        public string Surname { get; set; }
    }
}
