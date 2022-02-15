using System;

namespace Question11
{
    class Box
    {
        int length,breadth;
        public Box()
        {}
        public Box(int length,int breadth)
        {
            this.length=length;
            this.breadth=breadth;
        }
        public static Box operator+ (Box ob,Box ob2)
        {
            Box b3=new Box();
            b3.length=ob.length+ob2.length;
            b3.breadth=ob.breadth+ob2.breadth;
            return b3;
        }
        public void display()
        {
            Console.WriteLine("Length="+length+" Breadth="+breadth);
        }
    }
}
