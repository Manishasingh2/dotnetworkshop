using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BookFlightApi.Models
{
    public class FlightDetails
    {
      
        public int Flightid { get; set; }
       
        public string Flightname { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateTime? Departuretime { get; set; }
        public DateTime? Arrivaltime { get; set; }
        public int? Totalcapacity { get; set; }
        public double? Costperseat { get; set; }
        

        
    }
}
