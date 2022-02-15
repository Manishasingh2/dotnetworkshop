using System;
namespace  CollectionsEg
{
    class Emp
    {
        int eid;
        string name;
        float sal;
        DateTime doj;
        public Emp()
        {

        }
        public Emp(int eid,string name,float sal,DateTime doj)
        {
            this.eid=eid;
            this.name=name;
            this.sal=sal;
            this.doj=doj;
        }
        public override string ToString()
        {
            return string.Format(eid+"--"+name+"--"+sal+"--"+doj);
        }
    }
}