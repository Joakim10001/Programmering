using System;

namespace arv
{
    class Program
    {
        static void Main(string[] args)
        {
             Cat minKatt = new Cat(5);
            minKatt.Act(); 

            Dog minHund = new Dog(5);
            minHund.Act();    
        }

    }
}
