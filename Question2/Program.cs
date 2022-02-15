using System;

namespace Question2
{
    class Customer
    {
        int CustomerId,Age;
        string Name,City,Phone;
        public Customer()
        { 
            
        }
        public Customer(int CustomerId,int Age,string Name,string City,string Phone)
        {
            this.CustomerId=CustomerId;
            this.Age=Age;
            this.Name=Name;
            this.City=City;
            this.Phone=Phone;
        }
        public static void DisplayCustomer(Customer c)
        {
           Console.WriteLine("Customer ID "+c.CustomerId+" Customer Name: "+c.Name+" Customer Phone :"+c.Phone+" Customer Age: "+c.Age+" Customer City: "+c.City);
        }
        ~Customer()
        {
            Console.WriteLine("Destructor Called");
        }

    }
    class Program
    {
       /* static void Main(string[] args)
        {
  Customer customer=new Customer(1,5,"Manisha","Noida","2345678912");
//Customer customer=new Customer();
            Customer.DisplayCustomer(customer);
            GC.Collect();
        }*/
    }
}
