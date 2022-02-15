using FlightProject.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
namespace FlightProject
{
    public class BookingDetailsController:Controller
    {
        //public static DatabaseTrainingContext db=new DatabaseTrainingContext();
        private readonly DatabaseTrainingContext db;
        public BookingDetailsController(DatabaseTrainingContext _db)
        {
            db=_db;
        }
        public IActionResult customerbookingDetails()
        {
            return View();
        }
       [HttpGet]
        public IActionResult viewBookingDetails(int id)
        {
            BookingDetail b=db.BookingDetails.Find(id);
             return View(b);
        }
        


        

        
        
       
    }
}