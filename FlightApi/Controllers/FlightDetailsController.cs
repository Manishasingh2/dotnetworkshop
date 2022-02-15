using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using FlightApi.Models;
using FlightApi.Service;
namespace FlightApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightDetailsController : ControllerBase
    {
        private readonly IFlightDetailsServ<FlightDetails> f;
        public FlightDetailsController(IFlightDetailsServ<FlightDetails> service)
        {
            f = service;
        }
        [HttpGet]
        public IEnumerable<FlightDetails> Get()
        {
            return f.GetFlights();
        }

        [HttpGet("{id}")]
        public FlightDetails Get(int id)
        {
            return f.GetFlightsById(id);
        }
        [HttpPost]
        public void Post([FromBody] FlightDetails fd)
        {
            f.AddFlights(fd);
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] FlightDetails fd)
        {
            f.DeleteFlights(fd.Flightid);
            f.AddFlights(fd);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            f.DeleteFlights(id);
        }
    }
}
