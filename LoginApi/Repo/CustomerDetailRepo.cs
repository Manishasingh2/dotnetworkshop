using LoginApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace LoginApi.Repo
{
    public class CustomerDetailRepo:ICustomerDetailRepo
    {
        CustomerDetail cd=new CustomerDetail();
        public List<CustomerDetail> getICustomers()
        {
            return cd.getCustomers();
        }
        public void AddICustomer(CustomerDetail customerDetail)
        {
              cd.AddCustomer(customerDetail);
        }
        public CustomerDetail GetICustomerById(int id)
        {
            return cd.GetCustomerById(id);
        }
        public int LastCustomerId()
        {
            return cd.LastId();
        }
        public string GetCustomerICheck(int id,string name,string pass)
        {
            return cd.GetCustomerCheck(id,name,pass);
        }

   
    }
}