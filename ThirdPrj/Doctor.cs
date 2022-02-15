using System;

namespace ThirdPrj
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
       
    }
}
