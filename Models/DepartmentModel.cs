using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDataBaseApp.Models
{
    public class DepartmentModel
    {
        [Key]
        public int DepartamentId { get; set; }

        [Display(Name ="Название отдела")]
        public string DepartamentName { get; set; }

    }
}
