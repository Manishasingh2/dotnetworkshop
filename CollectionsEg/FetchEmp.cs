using System;
using System.Collections.Generic;
namespace  CollectionsEg
{
    class FetchEmp
    {
        public static void main(){
        List<Emp> e=new List<Emp>();
        e.Add(new Emp(1,"Manisha",1000,Convert.ToDateTime("1/2/2022")));
         e.Add(new Emp(2,"Singh",4000,Convert.ToDateTime("1/2/2022")));
          foreach(var item in e)
          {
              Console.WriteLine(item.ToString());
        }

        }
    }
}