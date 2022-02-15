using System;

namespace ThirdPrj
{
    abstract class Shape
    {   string color;
   protected float area;
#region 
    /*int age;
       public string Color{get;set;}
        public int Age{
         get {return age;}
         set{ if(value>0)
              {
                  age=value;
              }
              else
              {
                  age=0;
              }
         }}*/
#endregion
     public virtual void displaydetails()
        {
            Console.WriteLine("Base Class Data="+color);
        }
        public virtual void accept()
        {
            Console.WriteLine("Enter Color");
            color=Console.ReadLine();
        }
        public abstract void calculateArea();
      
       
    }
    class Rectangle:Shape
    {
        int length,breadth;
        public override void accept()
        {   base.accept();
            Console.WriteLine("ENter Length and breadth");
             length=Convert.ToInt32(Console.ReadLine());
            breadth=Convert.ToInt32(Console.ReadLine());
        }
       public override void displaydetails()
       {   base.displaydetails();
           Console.WriteLine("Length of Rectangle="+length);
           Console.WriteLine("Breadth of Rectangle="+breadth);
       }
       public override void calculateArea()
       {
         area=length*breadth;
         Console.WriteLine("Area of Rectangle="+area);
       }
    }

    class Circle:Shape
    {
        int radius;
       
        public override void accept()
        {   //base.accept();
             radius=Convert.ToInt32(Console.ReadLine());
           
        }
       public override void displaydetails()
       {   //base.displaydetails();
           
           Console.WriteLine("Radius="+radius);
       }
       public override void calculateArea()
       {
         area=3.14f*radius*radius;
         Console.WriteLine("Area of circle"+area);
       }
    }
}
