using System;
using System.Collections.Generic;

namespace arv_sak
{
    class Sak
    {
        protected string title;

        public virtual void Act()
      {
        Console.WriteLine(title);
      }
    }
}