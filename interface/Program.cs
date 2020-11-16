using System;

namespace interface1
{
    class Program
    {
        static void Main(string[] args)
        {
           Sphere sfär = new Sphere(5);
           Console.WriteLine(sfär.ToString() );

           Cylinder cylle = new Cylinder(4, 5);
           Console.WriteLine(cylle.ToString() );

           Cube kub = new Cube (7, 8);
           Console.WriteLine(kub.ToString() ); 

        }
    }
}
