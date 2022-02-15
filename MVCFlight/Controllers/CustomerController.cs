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
    public class CustomerController:Controller
    {
        string Baseurl = "https://localhost:5003/";
        string Baseurl2 = "https://localhost:5007/";
        string Baseurl3 = "https://localhost:5001/";
        public async Task<IActionResult> GetAllFlights(string serializedModel)
        {  
            string result=HttpContext.Session.GetString("result");
            ViewBag.Msg="Hello "+result;
            string custid=HttpContext.Session.GetString("custid");
            ViewBag.customerID1=custid;
            List<FlightDetails> model = JsonConvert.DeserializeObject<List<FlightDetails>>(serializedModel);
            return View(model);

        }
        [HttpGet]
        public async Task<IActionResult> CheckAvailability()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CheckAvailability(IFormCollection f)
        {
            string result=HttpContext.Session.GetString("result");
            string source1=f["source"];
            string destination1=f["dest"];
            ViewBag.Msg="Welcome "+result;
            List<FlightDetails> FlightInfo = new List<FlightDetails>();
            using (var client = new HttpClient())
            {
                
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/BookingDetail/Flights");    
                if (Res.IsSuccessStatusCode)
                {
                    var Response = Res.Content.ReadAsStringAsync().Result;
                    FlightInfo = JsonConvert.DeserializeObject<List<FlightDetails>>(Response);

                }
                List<FlightDetails> l=new List<FlightDetails>();
                foreach(var b in FlightInfo)
                {
                    if((b.Source==source1) && (b.Destination==destination1))
                    {
                        l.Add(b);
                    }

                }
                int listLenght = l.Count;
                if(listLenght > 0)
                {   return RedirectToAction("GetAllFlights",new { serializedModel = JsonConvert.SerializeObject(l)});}
                else
                {  
                    ViewBag.z="No Flight Available for this route!!";
                    return View();
                }
            }
        }
        
        [HttpGet]
        public async Task<IActionResult> BookFlights(int id,string foo,IFormCollection f)
        {   
            int bid=0;
            BookingDetail b=new BookingDetail();
            using (var client = new HttpClient())
            {
                
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/BookingDetail/getlastid");     
                if (Res.IsSuccessStatusCode)
                {
                    var Response = Res.Content.ReadAsStringAsync().Result;
                     bid = (int)JsonConvert.DeserializeObject<int>(Response);
                }   
              
            }
            int p=++bid;
            b.Bookingid=p;
            b.Customerid=Convert.ToInt32(foo);
            b.Flightid=id;
            b.Routeid=1;
            DateTime d=Convert.ToDateTime(f["Doj"]);
            b.Doj = d;
            int nop=Convert.ToInt32(f["Numberofpassengers"]);
            b.Numberofpassengers=nop;
            FlightDetails flightinfo=new FlightDetails();
            using (var client = new HttpClient())
            {
                
                client.BaseAddress = new Uri(Baseurl3);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/FlightDetails/"+id);     
                if (Res.IsSuccessStatusCode)
                {
                    var FlightResponse = Res.Content.ReadAsStringAsync().Result;
                    flightinfo = (FlightDetails)JsonConvert.DeserializeObject<FlightDetails>(FlightResponse);
                }  
            }
            b.Totalvalue = flightinfo.Costperseat*nop;
            return View(b);    
        }
        [HttpPost]
        public async Task<IActionResult> BookFlights(BookingDetail bookingDetail)
        {   
           
            FlightDetails flightinfo=new FlightDetails();
            using (var client = new HttpClient())
            {
                
                client.BaseAddress = new Uri(Baseurl3);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/FlightDetails/"+bookingDetail.Flightid);
                      
                if (Res.IsSuccessStatusCode)
                {
                    var Response = Res.Content.ReadAsStringAsync().Result;
                    flightinfo = (FlightDetails)JsonConvert.DeserializeObject<FlightDetails>(Response);

                }  
            }
            bookingDetail.Totalvalue = flightinfo.Costperseat*bookingDetail.Numberofpassengers;
            var Client = new HttpClient();
            Client.BaseAddress = new Uri(Baseurl);
            var myContent = JsonConvert.SerializeObject(bookingDetail);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await Client.PostAsync("api/BookingDetail", byteContent);
            var contents = await response.Content.ReadAsStringAsync();
            return RedirectToAction("GetAllBookings",new { id = bookingDetail.Bookingid });
        }

       
        public async Task<IActionResult> GetAllBookings(int id)
        {
            BookingDetail BookInfo = new BookingDetail();
            using (var client = new HttpClient())
            {
                
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/BookingDetail/"+id);     
                if (Res.IsSuccessStatusCode)
                {
                    var Response = Res.Content.ReadAsStringAsync().Result;
                    BookInfo = (BookingDetail)JsonConvert.DeserializeObject<BookingDetail>(Response);

                }
                return View(BookInfo);
            }

        }
        
        [HttpGet]
        public async Task<IActionResult> Register()
        {   
            int Info=0;
            CustomerDetail customerDetail=new CustomerDetail();
            using (var client = new HttpClient())
            {
                
                client.BaseAddress = new Uri(Baseurl2);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/CustomerDetail");     
                if (Res.IsSuccessStatusCode)
                {
                    var Response = Res.Content.ReadAsStringAsync().Result;
                    Info = (int)JsonConvert.DeserializeObject<int>(Response);

                }
              
            }
            int z=++Info;
            customerDetail.Customerid=z;
            return View(customerDetail);
            
        }
        [HttpPost]
        public async Task<IActionResult> Register(CustomerDetail c)
        {
            
            var Client = new HttpClient();
            Client.BaseAddress = new Uri(Baseurl2);
            var myContent = JsonConvert.SerializeObject(c);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await Client.PostAsync("api/CustomerDetail", byteContent);
            var contents = await response.Content.ReadAsStringAsync();
            int cid=c.Customerid;
            ViewBag.custId=cid;
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Login()
        {
            return View();
        }
        
         [HttpPost]
        public async Task<IActionResult> Login(IFormCollection f)
        { 
            int id=Convert.ToInt32(f["cid"]);
            string v1="verified",v2="notverified",v3="emptyfields",customerinfo="";
            string name1=f["name"];
            string pass1=f["pass"];
            using (var client = new HttpClient())
            {
                
                client.BaseAddress = new Uri(Baseurl2);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/CustomerDetail/"+id+"/"+name1+"/"+pass1);
                      
                if (Res.IsSuccessStatusCode)
                {
                    var Response = Res.Content.ReadAsStringAsync().Result;
                    customerinfo = (string)JsonConvert.DeserializeObject<string>(Response);

                }
                if(customerinfo==v3)
                {
                    ViewBag.result="Please enter Name or Password!!";
                    return View();
                }
                else if(customerinfo==v1)
                {
                    HttpContext.Session.SetString("result",name1);
                    HttpContext.Session.SetString("custid",id.ToString());
                    return RedirectToAction("CheckAvailability");
                }
                else if(customerinfo==v2)
                {
                    ViewBag.result="Please Enter Correct Name or Password!!";
                    return View();
                }
                else
                {
                    ViewBag.result="Please Enter Correct Unique ID!!";
                    return View();
                }
              }
        }
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return  RedirectToAction("Login");
        }
        [HttpGet]
        public async Task<IActionResult> ViewHistory()
        {
            string result=HttpContext.Session.GetString("result");
            string custid=HttpContext.Session.GetString("custid");
            int custid1=Convert.ToInt32(custid);
            ViewBag.Msg="Hello, "+result;
            List<BookingDetail> bookinginfo=new List<BookingDetail>();
            using (var client = new HttpClient())
            {
                    
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/BookingDetail/getallbooking");
                if (Res.IsSuccessStatusCode)
                {
                    var Response = Res.Content.ReadAsStringAsync().Result;
                    bookinginfo  = JsonConvert.DeserializeObject<List<BookingDetail>>(Response);

                }
                List<BookingDetail> bookingDetails=new List<BookingDetail>();
                foreach( var b in bookinginfo)
                {
                    if(b.Customerid==custid1)
                    {
                        bookingDetails.Add(b);
                    }
                }

                return View(bookingDetails);
            }
        }
    }
}