using System;
namespace Question2
{
    class enumeg
    {
        public enum DayofWeek
        {
            Sunday=1,Mon,Tue,Wed,Thur,Fri,Sat
        }
        public enum cities
        {
            mumbai,delhi,noida
        }
        /*static void Main(string [] args)
        {
            Console.WriteLine("ENter city");
            Enum.TryParse(Console.ReadLine(),out cities loc);
            Console.WriteLine(loc);
            string[] values=Enum.GetNames(typeof(DayofWeek));
            int total=0;
            
            foreach(string s in values)
            {
                Console.WriteLine(s);
                total++;
            }
            Console.WriteLine("TOtal "+total);
            int[] n=(int []) Enum.GetValues(typeof(DayOfWeek));
            foreach(int x in n)
            {
                Console.WriteLine(x);
            }
        }*/
    }
}