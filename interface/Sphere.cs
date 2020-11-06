using System;

namespace interface1
{
    class Sphere
    {

        protected double r;

        public Sphere(double radius1)
        {
            r = radius1;
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