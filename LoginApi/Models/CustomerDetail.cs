using System;
using System.Collections.Generic;
using System.Linq;
#nullable disable

namespace LoginApi.Models
{
    public class CustomerDetail
    {
        public int Customerid { get; set; }
        public string Customername { get; set; }
        public string Password { get; set; }

        static List<CustomerDetail> customerDetails = new List<CustomerDetail>();
        public CustomerDetail()
        {

        }

        public CustomerDetail(int Customerid,string Customername,string Password)
        {
           this.Customerid=Customerid;
           this.Customername=Customername;
           this.Password=Password;
        }

        public List<CustomerDetail> getCustomers()
        {
            
            return customerDetails;
        }

        public void AddCustomer(CustomerDetail customerDetail)
        {
            customerDetails.Add(customerDetail);

        }
        public CustomerDetail GetCustomerById(int id)
        {
            CustomerDetail customerDetail=customerDetails.Where(p => p.Customerid == id).FirstOrDefault();
            return customerDetail;
        }
    
         public int LastId()
         {
             CustomerDetail customerDetail=customerDetails.OrderByDescending(x =>x.Customerid).FirstOrDefault();
            return customerDetail.Customerid;
         }
         public string GetCustomerCheck(int id,string name,string pass)
         {
            CustomerDetail cd1=customerDetails.Where(p => p.Customerid == id).FirstOrDefault();
            if(cd1!=null)
            {
                if(name!="" && pass!="")
                {
                if(cd1.Customername==name && cd1.Password==pass)
                {
                    return "verified";
                }
                else
                {
                    return "notverified";
                }
                }
                else
                return "emptyfields";
            }
            
                return "notverifiedId";
            
            
         }

        
      
    }
}
