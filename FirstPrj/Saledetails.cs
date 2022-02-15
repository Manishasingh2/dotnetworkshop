using System;
namespace FirstPrj
{
    public class Saledetails
    {
        int Salesno,Productno,Price,Qty,TotalAmount;
        DateTime dos;
        public Saledetails(int Salesno,int Productno,int Price,int Qty,DateTime dos)
        {
            this.Salesno=Salesno;
            this.Productno=Productno;
            this.Price=Price;
            this.Qty=Qty;
            this.dos=dos;
        }
     public void sales()
        {
            TotalAmount=Qty*Price;
            Console.WriteLine("Total Price="+TotalAmount);
        }
        public void display()
        {
                Console.WriteLine("Salesno="+Salesno+" ProductNo="+Productno+" Date of Sale="+dos);
        }
      
    }
}
