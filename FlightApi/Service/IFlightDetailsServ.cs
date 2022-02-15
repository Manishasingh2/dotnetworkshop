using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlightApi.Models;
using FlightApi.Repo;

namespace FlightApi.Service
{
   public interface IFlightDetailsServ<FlightDetails>
    {
        public void AddFlights(FlightDetails f);
        public void DeleteFlights(int id);
        public List<FlightDetails> GetFlights();
        public FlightDetails GetFlightsById(int id);

    }

    
}
