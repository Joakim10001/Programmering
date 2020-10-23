using System;
using System.Collections.Generic;


namespace arv_sak
{
    class DVD : Sak
    {
        protected string regissör;

        public DVD(string title1, string regissör1)
        {
            title = title1;
            regissör = regissör1;

        }
        public override void Act()
      {
        Console.WriteLine(title + ", " + regissör);
      }
    }
}