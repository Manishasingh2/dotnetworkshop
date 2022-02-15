using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
#nullable disable

namespace MVCFlight.Models
{
    public class CustomerDetail
    {
        [Key]
        public int Customerid { get; set; }
        [Required(ErrorMessage="Please enter CustomerName")]
         [DisplayName("Customer Name")]
      
        public string Customername { get; set; }
         [DisplayName("Password")]
         [Required(ErrorMessage="Please enter Password")]
        public string Password { get; set; }
        

        
    }
}
