using System;

namespace Question7
{
    class Doctor
    {   int rgno,feescharged;
    string name;
   
     public string Name
     {
         get;set;
     }
        public int RGNO{
         get {return rgno;}
         set{ if(value>0)
              {
                  rgno=value;
              }
              else
              {
                  rgno=0;
              }
         }
        }

       public int FeesCharged
       {
           get;set;
       }
    }
}
