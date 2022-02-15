using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

#nullable disable

namespace MVCprjEF.Models
{
    public partial class ManishaSbaccount
    {
         [System.ComponentModel.DisplayName("Account Number")]
         [Required(ErrorMessage ="Please Enter Account no.")]
        public int Accno { get; set; }
        [Range(1,10000,ErrorMessage ="Enter balance between 1 to 10000")]
        [Required(ErrorMessage ="Please Enter balance.")]
        
        public decimal? Bal { get; set; }
        [Required(ErrorMessage ="Please Enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please Enter Address")]
        public string Address { get; set; }
    }
}
