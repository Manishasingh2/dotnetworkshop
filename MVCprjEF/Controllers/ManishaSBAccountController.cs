using System.Collections.Generic;
using MVCprjEF.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using MVCprjEF.ViewModels;
using System.IO;

namespace MVCprjEF
{
    public class ManishaSBAccountController:Controller
    {
        //public static DatabaseTrainingContext db=new DatabaseTrainingContext();
        private readonly DatabaseTrainingContext db;
        private readonly IWebHostEnvironment  webHostEnvironment;
        public ManishaSBAccountController(DatabaseTrainingContext _db,IWebHostEnvironment _web)
        {   webHostEnvironment=_web;
            db=_db;
        }
        public IActionResult getallEmps()
        {
            return View(db.ManishaSbaccounts.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(sbaccountvm p)
        {  using (var db=new DatabaseTrainingContext() )
            {
                 string uniqueFileName = null;  
  
            if (p.Address != null)  
            {  
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");  
                //uniqueFileName = Guid.NewGuid().ToString() + "_" + p.Pimage.FileName;  
                uniqueFileName=p.Address.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);  
                using (var fileStream = new FileStream(filePath, FileMode.Create))  
                {  
                    p.Address.CopyTo(fileStream);  
                }  
                ManishaSbaccount p1=new ManishaSbaccount();
                p1.Accno=p.Accno;
                p1.Bal=p.Bal;
                p1.Name=p.Name;
                p1.Address="~/images/"+uniqueFileName;
                db.ManishaSbaccounts.Add(p1);
                db.SaveChanges();
                return RedirectToAction("getallEmps");
            }
            else
             return View();
            }
        }
           
        
        public IActionResult Edit(int id)
        {  
            ManishaSbaccount sb=db.ManishaSbaccounts.Find(id);
            return View(sb);
            
        }
        [HttpPost]
        public IActionResult Edit(ManishaSbaccount sb)
        {   if(ModelState.IsValid)
            {
            db.ManishaSbaccounts.Update(sb);
            db.SaveChanges();
            return RedirectToAction("getallEmps");
            }
            else
            return View();


        }
        public IActionResult Details(int id)
        {
            ManishaSbaccount sb=db.ManishaSbaccounts.Find(id);
            return View(sb);
        }
        public IActionResult Delete(int id)
        {
            ManishaSbaccount sb=db.ManishaSbaccounts.Find(id);
            return View(sb);    
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            ManishaSbaccount sb=db.ManishaSbaccounts.Find(id);
            db.ManishaSbaccounts.Remove(sb);
            db.SaveChanges();
            return RedirectToAction("getallEmps");    
        }
    }
}