using FlightApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApi.Repo
{
    public class FlightDetailsRepo : IFlightDetailsRepo<FlightDetails>
    {
        private readonly IFlightDetails<FlightDetails> f;
        public  FlightDetailsRepo()
        {

        }
        public FlightDetailsRepo(IFlightDetails<FlightDetails> _f)
        {
            f = _f;
        }
        public void AddFlights(FlightDetails f)
        {
            f.AddFlights(f);   
        }

        public void DeleteFlights(int id)
        {
            f.DeleteFlights(id);
        }

        public FlightDetails GetFlightsById(int id)
        {
            return f.GetFlightsById(id);
        }

        public List<FlightDetails> GetFlights()
        {
           return f.GetFlights();
        }
    }
}
