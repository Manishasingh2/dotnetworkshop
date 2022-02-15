using System;
namespace FirstPrj
{
    class Q1
    {
        static void Main(string[] args)
        {   
            DateTime dateTime=new DateTime(2022,01,18);
            Console.WriteLine("Enter Price and Quantity");
            int price=Convert.ToInt32(Console.ReadLine());
            int qty=Convert.ToInt32(Console.ReadLine());
            Saledetails saledetails=new Saledetails(1,5,price,qty,dateTime);
            saledetails.sales();
            saledetails.display();
            
        }
    }
}
