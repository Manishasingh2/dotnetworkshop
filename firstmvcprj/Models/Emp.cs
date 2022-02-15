using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
namespace firstmvcprj.Models
{
    public class Emp
    {
        [System.ComponentModel.DisplayName("Employee ID")]
        
        public int Empid{get;set;}
        public string Ename{get;set;}
        public int Esalary{get;set;}
        public Emp()
        {

        }
        public Emp(int eid,string ename,int sal)
        {
            Empid=eid;
            Ename=ename;
        Esalary=sal;
        }
         public static List<Emp> employees=new List<Emp>();
        public static List<Emp> getEmployees()
        {
           
            employees.Add(new Emp(101,"Manisha",5000));
            employees.Add(new Emp(102,"Tom",6000));
            return employees;
        }
        
    
    }
}