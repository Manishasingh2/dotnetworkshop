using LoginApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginApi.Repo
{
    public interface ICustomerDetailRepo
    {
        public List<CustomerDetail> getICustomers();
        public void AddICustomer(CustomerDetail customerDetail);
        public CustomerDetail GetICustomerById(int id);
        public int LastCustomerId();
        public string GetCustomerICheck(int id,string name,string pass);
    }
}