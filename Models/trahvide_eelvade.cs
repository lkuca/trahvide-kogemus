using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace trahvide_kogemus.Models
{
    public class trahvide_eelvade
    {
        [Required(ErrorMessage = "Sissesta nimi")]
        public string Nimi { get; set; }
        [Required(ErrorMessage = "sissesta Email")]
        [RegularExpression(@".+\@.+\..+", ErrorMessage = "valesti sissestatud email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Sissesta isikukoodi numbrid")]
        public int isikukood { get; set; }
        [Required(ErrorMessage = "Sisesta oma pin")]

        public int pin { get; set; }
    }

}