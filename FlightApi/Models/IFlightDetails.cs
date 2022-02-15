using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApi.Models
{
   public interface IFlightDetails<FlightDetails>
    {
        public void AddFlights(FlightDetails f);
        public void DeleteFlights(int id);
        public List<FlightDetails> GetFlights();
        public FlightDetails GetFlightsById(int id);
    }
}
