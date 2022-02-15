using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MVCFlight.Models
{
    public class FlightDetails
    {
    [Key]
      [DisplayName("Flight ID")]
        public int Flightid { get; set; }
       [DisplayName("Flight Name")]
       [Required(ErrorMessage ="Please enter flight name")]
        public string Flightname { get; set; }


         [Required(ErrorMessage ="Please enter Source")]
        public string Source { get; set; }
         [Required(ErrorMessage ="Please enter Destination")]
        public string Destination { get; set; }
        [DisplayName("Departure Time")]
         [Required(ErrorMessage ="Please enter Departure Time")]
        public DateTime? Departuretime { get; set; }
        [DisplayName("Arrival Time")]
         [Required(ErrorMessage ="Please enter Arrival Time")]
        public DateTime? Arrivaltime { get; set; }
        [DisplayName("Capacity")]
         [Required(ErrorMessage ="Please enter Total Capacity")]
        public int? Totalcapacity { get; set; }
        [DisplayName("Cost Per Seat")]
         [Required(ErrorMessage ="Please enter Cost per seat")]
        public double? Costperseat { get; set; }
        

        
    }
}
