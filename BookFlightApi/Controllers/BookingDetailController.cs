using BookFlightApi.Models;
using BookFlightApi.Repo;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
namespace BookFlightApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingDetailController : ControllerBase
    {
    
        BookingDetailRepo bookingDetailRepo=new BookingDetailRepo();    
        [HttpGet("getlastid")]
        public int GetLast()
        {
            return bookingDetailRepo.GetILastBookingID();
        }

        [HttpGet("{id}")]
        public BookingDetail Get(int id)
        {
            return bookingDetailRepo.GetBookingByIId(id);
        }
        [HttpGet("getallbooking")]
        public IEnumerable<BookingDetail> GetAllBook()
        {
            return bookingDetailRepo.getBookingIItems();
        }
        [HttpGet("Flights")]
        public async Task<List<FlightDetails>> GetFlights()
        {

            string Baseurl = "https://localhost:5001/";
            List<FlightDetails> Info = new List<FlightDetails>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/FlightDetails");
                if (Res.IsSuccessStatusCode)
                {
                    var Response = Res.Content.ReadAsStringAsync().Result;
                    Info = JsonConvert.DeserializeObject<List<FlightDetails>>(Response);
                    return Info;
                }
                else
                {
                    return null;
                }

            }
        }
        [HttpPost]
        public  void Post([FromBody] BookingDetail c)
        {
               bookingDetailRepo.AddIBooking(c);
            
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           bookingDetailRepo.DeleteIItem(id);
        }
    }
}
