using FlightProject.Models;
using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
namespace FlightProject
{
    public class CustomerDetailsController:Controller
    {
       
        private readonly DatabaseTrainingContext db;
        public CustomerDetailsController(DatabaseTrainingContext _db)
        {
            db=_db;
        }
        public IActionResult customers()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {   CustomerDetail customerDetail=new CustomerDetail();
            var v= db.CustomerDetails.OrderByDescending(x => x.Customerid).FirstOrDefault();
            int k=v.Customerid;
            int z=++k;
            customerDetail.Customerid=z;
            return View(customerDetail);
        }

        [HttpPost]
        public IActionResult Create(IFormCollection f,CustomerDetail customerDetail)
        {
            db.CustomerDetails.Add(customerDetail);
            db.SaveChanges();
            int cid=customerDetail.Customerid;
            ViewBag.custId=cid;
            ModelState.Clear();
            return View();
            
        }
        [HttpGet]
        public IActionResult viewFlights()
        {   
            string result=HttpContext.Session.GetString("result");
            string custid=HttpContext.Session.GetString("custid");
            ViewBag.customerID1=custid;
            ViewBag.Msg="Welcome "+result;
            return View(db.FlightDetails.ToList());
        }
        [HttpGet]
        public IActionResult bookFlight(int id,string foo,IFormCollection f)
        {   
            HttpContext.Session.SetString("Session2","sess2");
            BookingDetail b= new BookingDetail();
            RouteDetail route = db.RouteDetails.Where(x => x.Flightid == id).SingleOrDefault();
            FlightDetail fd=db.FlightDetails.Find(id);
            var v= db.BookingDetails.OrderByDescending(x => x.Bookingid).FirstOrDefault();
            int p=v.Bookingid;
            b.Customerid=Convert.ToInt32(foo);
            b.Bookingid=++p;
            b.Flightid =id;
            b.Routeid = route.Routeid;
            DateTime d=Convert.ToDateTime(f["Doj"]);
            b.Doj = d;
            int nop=Convert.ToInt32(f["Numberofpassengers"]);
            b.Numberofpassengers=nop;
            b.Totalvalue = fd.Costperseat*nop;
            return View(b);
        }
        [HttpPost]
        public IActionResult bookFlight(BookingDetail bookingDetail)
        {   
            string result2=HttpContext.Session.GetString("Session2");
            HttpContext.Session.SetString("session3","sess");
            FlightDetail fd=db.FlightDetails.Where(x=>x.Flightid==bookingDetail.Flightid).FirstOrDefault();
            bookingDetail.Totalvalue=fd.Costperseat*bookingDetail.Numberofpassengers;
            db.BookingDetails.Add(bookingDetail);
            db.SaveChanges();
            return RedirectToAction("viewBookingDetails",new {id=bookingDetail.Bookingid});

        }

         [HttpGet]
        public IActionResult viewBookingDetails(int id,string name)
        {   string result=HttpContext.Session.GetString("result");
        
            ViewBag.message=result;
            BookingDetail b=db.BookingDetails.Find(id);
            return View(b);
        }
       [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
         [HttpPost]
        public IActionResult Login(IFormCollection f)
        {
            int id=Convert.ToInt32(f["cid"]);
            string name1=f["name"];
            string pass1=f["pass"];
            
            CustomerDetail customerDetail=db.CustomerDetails.Where(x=>x.Customerid==id).SingleOrDefault();
            if(customerDetail!=null)
            {
              if(customerDetail.Customername==name1 && customerDetail.Password==pass1)
              { 
                HttpContext.Session.SetString("result",name1);
                HttpContext.Session.SetString("custid",id.ToString());
                return RedirectToAction("viewFlights");
              }
              else
              {
                ViewBag.result="Please Enter Correct Name or Password!!";
                return View();
              }
            }
            ViewBag.result="Please Enter Correct Unique ID!!";
            return View();
        }
          [HttpGet]
        
       
       
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return  RedirectToAction("Login");
        }

        
        


        
    }
}