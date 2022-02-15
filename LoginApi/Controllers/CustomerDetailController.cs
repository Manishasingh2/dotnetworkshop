using System;
using LoginApi.Models;
using LoginApi.Repo;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace LoginApi.Controllers
{  [Route("api/[controller]")]
    [ApiController]
    public class CustomerDetailController : ControllerBase
    {
        
       CustomerDetailRepo customerDetailRepo=new CustomerDetailRepo();
        /*[HttpGet]
        public IEnumerable<CustomerDetail> Get()
        {
            return customerDetailRepo.getICustomers();
        }*/
        [HttpGet("{id}")]
        public CustomerDetail Get(int id)
        {
            return customerDetailRepo.GetICustomerById(id);
        }

            // POST api/<CartController>
        [HttpPost]
        public void Post([FromBody] CustomerDetail c)
        {
                customerDetailRepo.AddICustomer(c);
            
        }
        [HttpGet]
        public int Get()
        {
            return customerDetailRepo.LastCustomerId();
        }

         
        [HttpGet("{id}/{name}/{pass}")]
        
         public string Get(int id,string name,string pass)
         {
             return customerDetailRepo.GetCustomerICheck(id,name,pass);
         }
        

       
    }
    
}