using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace LINQEg
{
    class Program
    {
        class ProductStore
        {
            public string productName { get; set; }
            public int productPrice { get; set; }         
        }
        static void main(string[] args)
        {
            /*List<int> numbers=new List<int>(){1,2,3,4,5};
            //Query syntax
            var res=(from i in numbers
                    where i%2==0
                    select i).ToList();
            foreach(var item in res)
            {
                Console.WriteLine(item);
            }
            //Method syntax
            var res1=numbers.Where(x=>x%2==0).Select(x=>x).ToList();
            Console.WriteLine("Using Method syntax");
            foreach(var item in res1)
            {
                Console.WriteLine(item);
            }*/
            ArrayList productList = new ArrayList();
            productList.Add(new ProductStore { productName = "Hard Disk", productPrice = 1280 });
            productList.Add(new ProductStore { productName = "Monitor", productPrice = 3000 });
            productList.Add(new ProductStore { productName = "SSD Disk", productPrice = 3500 });
            productList.Add(new ProductStore { productName = "RAM", productPrice = 2450 });
            productList.Add(new ProductStore { productName = "Processor", productPrice = 7680 });
            productList.Add(new ProductStore { productName = "Bluetooth", productPrice = 540 });
            productList.Add(new ProductStore { productName = "Keyboard", productPrice = 1130 });
 
            //Method 1: Query Expression
            var search = from ProductStore p in productList
                         where p.productName.Contains("Disk")
                         select p;
 
            
            
            foreach (var result in search)
            {
                Console.WriteLine("Product Name: {0}, Price: {1}", result.productName, result.productPrice);
            }
 
        }
    }
}
