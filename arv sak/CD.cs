using System;
using System.Collections.Generic;

namespace arv_sak
{
    class CD : Sak
    {
      protected string artist;  
      public CD(string title1, string artist1)
      {
          title = title1;
          artist = artist1;


      }
      public override void Act()
      {
        Console.WriteLine(title + ", " + artist);
      }
    }
}