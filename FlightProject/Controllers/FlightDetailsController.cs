using FlightProject.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace FlightProject
{
    public class FlightDetailsController:Controller
    {
        //public static DatabaseTrainingContext db=new DatabaseTrainingContext();
        private readonly DatabaseTrainingContext db;
        private readonly IWebHostEnvironment  webHostEnvironment;
        public FlightDetailsController(IWebHostEnvironment _web,DatabaseTrainingContext _db)
        {webHostEnvironment=_web;
            db=_db;
        }
        //View Flights
        public IActionResult getAllFlights()
        {
            return View(db.FlightDetails.ToList());
        }

        //Add New Flight
        [HttpGet]
        public IActionResult Create()
        {
             var v= db.FlightDetails.OrderByDescending(x => x.Flightid).FirstOrDefault();
                int n=v.Flightid;
                int z=++n;
                FlightDetailsVM f=new FlightDetailsVM();
                f.Flightid=z;
            return View(f);
        }

        [HttpPost]
        public IActionResult Create(FlightDetailsVM p)
        {
            string uniqueFileName = null;  
  
            if (p.Imagepath != null)  
            {  
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");  
                //uniqueFileName = Guid.NewGuid().ToString() + "_" + p.Pimage.FileName;  
                uniqueFileName=p.Imagepath.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);  
                using (var fileStream = new FileStream(filePath, FileMode.Create))  
                {  
                    p.Imagepath.CopyTo(fileStream);  
                }  
                FlightDetail p1=new FlightDetail();
               
                p1.Flightid=p.Flightid;
                p1.Flightid=p.Flightid;
                p1.Source=p.Source;
                p1.Flightname=p.Flightname;
                p1.Costperseat=p.Costperseat;
                p1.Destination=p.Destination;
                p1.Departuretime=p.Departuretime;
                p1.Arrivaltime=p.Arrivaltime;
                p1.Totalcapacity=p.Totalcapacity;
                p1.Imagepath="~/images/"+uniqueFileName;
                db.FlightDetails.Add(p1);
            db.SaveChanges();
            return RedirectToAction("getAllFlights");
            }
            else
             return View();
            
        }
        //Edit Details of flight
       // [Route("editing/{flightid:int}")]
        public IActionResult Edit(int flightid)
        {   FlightDetail fd=db.FlightDetails.Find(flightid);
            return View(fd);
        }
        [HttpPost]
        public IActionResult Edit(FlightDetail fd)
        {   db.FlightDetails.Update(fd);
            db.SaveChanges();
            return RedirectToAction("getAllFlights");

        }
        [HttpGet]
        public IActionResult Delete(int flightid)
        {
            FlightDetail fd=db.FlightDetails.Find(flightid);
            db.FlightDetails.Remove(fd);
            db.SaveChanges();
            return RedirectToAction("getAllFlights"); 
            //return View(fd);    
        }

        /*[HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirmed(int flightid)
        {
            FlightDetail fd=db.FlightDetails.Find(flightid);
            db.FlightDetails.Remove(fd);
            db.SaveChanges();
            return RedirectToAction("getAllFlights");    
        }*/

         [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
         [HttpPost]
        public IActionResult Login(IFormCollection f)
        {
           
            string name1=f["name"];
            string pass1=f["pass"];
            
            
              if(name1=="Admin" && pass1=="admin")
              {
               
                return RedirectToAction("getAllFlights");
              }
                string result="Please Enter Correct Name or Password!!";
                ViewBag.result=result;
                return View();
              
            
    }
        

    }
}
