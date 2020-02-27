using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolDataBaseApp.Models
{
    public class SpecializationStaffModel
    {
        [Key]
        public int SpecializationId { get; set; }

        [Display(Name ="Специализация")]
        public string SpecializationName { get; set; }


    }
}
