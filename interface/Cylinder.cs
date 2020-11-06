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
           return 4 * Math.PI * r * r;
           
       }
       public double GetVolume()
       {
           return 4 * Math.PI * r * r * r / 3;
       }

       public override string ToString()
       { 
           return "Sphere: " +Environment.NewLine + "Radius=" +r +Environment.NewLine + "Volume=" +GetVolume() +Environment.NewLine + "Area=" +GetArea() ;
           
       }
    }
}