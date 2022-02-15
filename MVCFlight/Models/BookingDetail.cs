using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

#nullable disable

namespace MVCFlight.Models
{
    public  class BookingDetail
    {  [Key]
        [DisplayName("Booking ID")]
        public int Bookingid { get; set; }
        [DisplayName("Flight ID")]
        public int? Flightid { get; set; }
        [DisplayName("Route ID")]
        public int? Routeid { get; set; }
        [DisplayName("Date Of Journey")]
        [Required(ErrorMessage ="Please enter Date of journey")]
        public DateTime? Doj { get; set; }
        [DisplayName("Number Of Passengers")]
        [Required(ErrorMessage ="Please enter no. of passenger")]
        
        public int? Numberofpassengers { get; set; }
        [DisplayName("Total Amount")]
        public double? Totalvalue { get; set; }
        [DisplayName("Customer ID")]
        public int? Customerid { get; set; }
      
        
    }
    
}
