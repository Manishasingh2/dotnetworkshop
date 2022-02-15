using System;
using System.Collections;
using System.Collections.Generic;
namespace CollectionsEg
{
    class Program
    {
        static void main(string[] args)
        {
            /*ArrayList arrayList=new ArrayList();
            arrayList.Add("Manisha");
            arrayList.Add(true);
            arrayList.Add(5);
            ArrayList a=new ArrayList();
            a.Add(5);a.Add(100);a.Add(23);a.Add(45);
            a.Sort();

            arrayList.InsertRange(1,a);
            arrayList.Remove(true);
            foreach(var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count of first arrayList"+arrayList.Count);
            Console.WriteLine("Capacity of first arrayList"+arrayList.Capacity);*/
            List<int> l=new List<int>();
            l.Add(1);
            l.Add(2);
            l.Add(3);
            l.Add(4);
            foreach(var item in l)
            {
                Console.WriteLine(item);
            }


           
           
        }
    }
}
