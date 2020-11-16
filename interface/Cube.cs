using System;

namespace interface1
{
    class Cube
    {
        protected double r;

        protected double l;

        public Cube(double radius1, double lenght1)
        {
            r = radius1;
            l = lenght1;
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
           return "Cube: " +Environment.NewLine + "Radius=" +r +Environment.NewLine + "lenght=" +l +Environment.NewLine + "Volume=" +GetVolume() +Environment.NewLine + "Area=" +GetArea() ;
           
       }
    }
}