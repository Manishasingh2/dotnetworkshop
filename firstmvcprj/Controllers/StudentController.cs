using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
namespace firstmvcprj.Controllers
{
    
    public class StudentController:Controller
    { [Route("Adding")]
       [HttpGet]
        public IActionResult AddNumbers()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNumbers(IFormCollection f)
        {
            int a=Convert.ToInt32(f["first"]);
            int b=Convert.ToInt32(f["second"]);
            int c=a+b;
            //int a=Convert.ToInt32(Request.Form["first"]);
            /*ViewBag.result=c;
            return View();*/
            HttpContext.Session.SetString("result",c.ToString());
            return RedirectToAction("StudentResult");

        }

       
        public IActionResult StudentResult()
        {ViewBag.result=HttpContext.Session.GetString("result");
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("AddNumbers");
        }

    }
}