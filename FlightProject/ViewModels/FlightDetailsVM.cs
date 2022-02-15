
using Microsoft.AspNetCore.Http;
using System;

namespace FlightProject
{
   public class FlightDetailsVM
    {
        public int Flightid { get; set; }
        public string Flightname { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateTime? Departuretime { get; set; }
        public DateTime? Arrivaltime { get; set; }
        public int? Totalcapacity { get; set; }
        public double? Costperseat { get; set; }
        public IFormFile Imagepath { get; set; }

    }
}