using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlightApi.Models;

namespace FlightApi.Repo
{
    public interface IFlightDetailsRepo<FlightDetails>
    {
        public void AddFlights(FlightDetails f);
        public void DeleteFlights(int id);
        public List<FlightDetails> GetFlights();
        public FlightDetails GetFlightsById(int id);
    }

    
}
