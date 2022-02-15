using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using System.Text;
using MVCFlight.Models;
using System.Threading.Tasks;

namespace MVCFlight.Controllers
{
    public class AdminController:Controller
    {

        string Baseurl = "https://localhost:5001/";
        public async Task<IActionResult> getAllFlights()
        {  
            string result=HttpContext.Session.GetString("result");
            ViewBag.Msg="Welcome "+result;
            List<FlightDetails> FlightInfo = new List<FlightDetails>();
            using (var client = new HttpClient())
            {
                
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/FlightDetails");     
                if (Res.IsSuccessStatusCode)
                {
                    var ProductResponse =Res.Content.ReadAsStringAsync().Result;
                    FlightInfo = JsonConvert.DeserializeObject<List<FlightDetails>>(ProductResponse);
                    return View(FlightInfo);
                }
                return null;
               
                
            }
        }
        [HttpGet]
        public async Task<IActionResult> CreateFlight()
        {

            List<FlightDetails> FlightInfo=new List<FlightDetails>();
            using (var client = new HttpClient())
            {
                
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/FlightDetails");      
                if (Res.IsSuccessStatusCode)
                {
                    var ProductResponse = Res.Content.ReadAsStringAsync().Result;
                    FlightInfo = JsonConvert.DeserializeObject<List<FlightDetails>>(ProductResponse);

                }
                int fid=0,p=0;
                FlightInfo.Reverse();
                int x=FlightInfo.Count-1;
                if(x<0)
                    fid=1;
                else
                {
                    FlightDetails f1=FlightInfo[x];
                    p=f1.Flightid;
                    fid=++p;
                }
                FlightDetails f=new FlightDetails();
                f.Flightid=fid;
                return View(f);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateFlight(FlightDetails flightDetails)
        {  
            string result=HttpContext.Session.GetString("result");
            ViewBag.Msg="Hii "+result;
            using(var Client = new HttpClient())
            {
            Client.BaseAddress = new Uri(Baseurl);
            var myContent = JsonConvert.SerializeObject(flightDetails);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await Client.PostAsync("api/FlightDetails", byteContent);
            var contents = await response.Content.ReadAsStringAsync();
            return RedirectToAction("getAllFlights");
            }
            
        }
        
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
            HttpContext.Session.SetString("result",name1);
            if(name1!="" && pass1!="")
            { 
                if(name1=="Admin" && pass1=="admin")
                {
               
                    return RedirectToAction("getAllFlights");
                }
                string result="Please Enter Correct Name or Password!!";
                ViewBag.result=result;
            }
            else
            {
                string result="Name or Password cannot be Empty!!";
                ViewBag.result=result;
            }
                
            return View();     
        }
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return  RedirectToAction("Login");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int flightid)
        {
              
           
            using(HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                var response = await client.DeleteAsync("api/FlightDetails/"+flightid);
                if (response.IsSuccessStatusCode)
                {
                    var result=await response.Content.ReadAsStringAsync();
                    return RedirectToAction("getAllFlights");
                }
                else
                return null;
            }
            
           
        }

        [HttpGet]
        public async Task<IActionResult>Edit(int flightid)
        {   
            
            FlightDetails FlightInfo = new FlightDetails();
            using (var client = new HttpClient())
            {
                
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/FlightDetails/"+flightid);     
                if (Res.IsSuccessStatusCode)
                {
                    var ProductResponse = Res.Content.ReadAsStringAsync().Result;
                    FlightInfo = JsonConvert.DeserializeObject<FlightDetails>(ProductResponse);

                }
                return View(FlightInfo);
           }
        }
        [HttpPost]
        public async Task<IActionResult> Edit(FlightDetails fd)
        {
            int fid=fd.Flightid;
   
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Baseurl);
            var myContent = JsonConvert.SerializeObject(fd);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await client.PutAsync("api/FlightDetails/"+fid,byteContent);
            if (response.IsSuccessStatusCode)
            {
                var result=await response.Content.ReadAsStringAsync();
                 
            }
            return RedirectToAction("getAllFlights"); 
              
        }
    }
}