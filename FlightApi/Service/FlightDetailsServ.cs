using FlightApi.Models;
using FlightApi.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApi.Service
{
    public class FlightDetailsServ : IFlightDetailsServ<FlightDetails>
    {
        private readonly IFlightDetailsRepo<FlightDetails> p;
        public FlightDetailsServ()
        {

        }
        
        public FlightDetailsServ(IFlightDetailsRepo<FlightDetails> _p)
        {
            p = _p;
        }
        public void AddFlights(FlightDetails p)
        {
            p.AddFlights(p);   
        }

        public void DeleteFlights(int id)
        {
            p.DeleteFlights(id);
        }

        public FlightDetails GetFlightsById(int id)
        {
            return p.GetFlightsById(id);
        }

        public List<FlightDetails> GetFlights()
        {
           return p.GetFlights();
        }
    }
}
