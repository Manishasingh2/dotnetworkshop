using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace FlightApi.Models
{
    public class FlightDetails:IFlightDetails<FlightDetails>
    {
        [Key]
        public int Flightid { get; set; }
       
        public string Flightname { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateTime? Departuretime { get; set; }
        public DateTime? Arrivaltime { get; set; }
        public int? Totalcapacity { get; set; }
        public double? Costperseat { get; set; }
        public static List<FlightDetails> flights= new List<FlightDetails>();
        public FlightDetails(int Flightid, string Flightname,string Source,string Destination,DateTime Departuretime, DateTime Arrivaltime,int Totalcapacity ,double Costperseat)
        {
            this.Flightid=Flightid;
            this.Flightname=Flightname;
            this.Source=Source;
            this.Destination=Destination;
            this.Departuretime=Departuretime;
            this.Arrivaltime=Arrivaltime;
            this.Totalcapacity=Totalcapacity;
            this.Costperseat=Costperseat;
        }

        public FlightDetails()
        {
            
        }

        public List<FlightDetails> GetFlights()
        {
          
           return flights;
        }
        public void AddFlights(FlightDetails f)
        {
            flights.Add(f);

        }
        public void DeleteFlights(int id)
        {
            FlightDetails f = GetFlightsById(id);
            flights.Remove(f);
        }
        public FlightDetails GetFlightsById(int id)
        {
            flights = GetFlights();
            FlightDetails f = flights.Where(p=>p.Flightid==id).FirstOrDefault();
            return f;
        }

       
    }
}
