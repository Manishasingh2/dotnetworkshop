using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using firstmvcprj.Models;
using System;
namespace firstmvcprj.Controllers
{
    
    public class ProductController:Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ProductController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor=httpContextAccessor;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Emp obj)
        {
              CookieOptions options=new CookieOptions();
              int ? expireTime=5;
              if(obj.Ename=="manisha" && obj.Empid==123)
              {
                  if(expireTime.HasValue)
                  {
                      options.Expires=DateTime.Now.AddMinutes(expireTime.Value);

                  }
                  else
                  options.Expires=DateTime.Now.AddMilliseconds(2000);
                  Response.Cookies.Append("username",obj.Ename,options);
                  return RedirectToAction("Dashboard");
              }
              else
                return View();
        }
        public IActionResult Dashboard()
        {
            string username=_httpContextAccessor.HttpContext.Request.Cookies["username"];
            ViewBag.Msg="Welcome"+username;
            return View();
        }

    }
}