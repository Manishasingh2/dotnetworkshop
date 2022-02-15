using FlightProject.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
namespace FlightProject
{
    public class RouteDetailsController:Controller
    {
        //public static DatabaseTrainingContext db=new DatabaseTrainingContext();
        private readonly DatabaseTrainingContext db;
        public RouteDetailsController(DatabaseTrainingContext _db)
        {
            db=_db;
        }
       
        public IActionResult getAllRoutes()
        {
            return View(db.RouteDetails.ToList());
        }
        
        [HttpGet]
        public IActionResult Create()
        {
             var v= db.RouteDetails.OrderByDescending(x => x.Routeid).FirstOrDefault();
                int n=v.Routeid;
                int z=++n;
                RouteDetail r=new RouteDetail();
               r.Routeid=z;
            return View(r);
        }

        [HttpPost]
        public IActionResult Create(RouteDetail routeDetail)
        {
            db.RouteDetails.Add(routeDetail);
            db.SaveChanges();
            return RedirectToAction("getAllRoutes");
        }
        
        [HttpGet]
        public IActionResult Edit(int id)
        {   RouteDetail rd=db.RouteDetails.Find(id);
            return View(rd);
        }
        [HttpPost]
        public IActionResult Edit(RouteDetail rd)
        {   db.RouteDetails.Update(rd);
            db.SaveChanges();
            return RedirectToAction("getAllRoutes");

        }
        
        [HttpGet]
        public IActionResult Delete(int id)
        {
            RouteDetail rd=db.RouteDetails.Find(id);
            db.RouteDetails.Remove(rd);
            db.SaveChanges();
            return RedirectToAction("getAllRoutes"); 
               
        }

        
      
    }
}