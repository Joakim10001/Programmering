using System;

namespace interface1
{
    class Cylinder
    {
        protected double r;
        protected double h;

        public Cylinder(double radius1, double height1)
        {
            r = radius1;
            h = height1;
        }
       public double GetArea()
       {
           return 4 * Math.PI * r * r ;
           
       }
       public double GetVolume()
       {
           return Math.PI * r * r * h;
       }

       public override string ToString()
       { 
           return "Cylinder: " +Environment.NewLine + "Radius=" +r +Environment.NewLine + "Heigt=" +h +Environment.NewLine + "Volume=" +GetVolume() +Environment.NewLine + "Area=" +GetArea() ;
           
       }
    }
}