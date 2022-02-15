using Microsoft.AspNetCore.Mvc;
using firstmvcprj.Models;
using System.Linq;
using System.Collections.Generic;
namespace firstmvcprj.Controllers
{
    public class EmployeeController : Controller
    { 
       //Emp obj=new Emp();
       public static List<Emp> l=Emp.getEmployees();
        
        public IActionResult Sample()
        {
        ViewData["age"]=23;
        ViewBag.Companyname="FP";
        
            return View();
        }
        [HttpGet]
        public IActionResult GetEmployeeDetails()
        {
            //List<Emp> l=Emp.getEmployees();
            return View(l);
            
        }
        [HttpGet]
        public IActionResult AddNewEmployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNewEmployee(Emp e)
        {
            l.Add(e);
            return RedirectToAction("GetEmployeeDetails");
        }
        [HttpGet]
        public IActionResult KnowMore(int id)
        {
            Emp res=l.Where(x=>x.Empid==id).FirstOrDefault();
            return View(res);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Emp res=l.Where(x=>x.Empid==id).FirstOrDefault();
            l.Remove(res);
            return RedirectToAction("GetEmployeeDetails");
        }


    }
}