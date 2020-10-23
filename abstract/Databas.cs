using System;
using System.Collections.Generic;

namespace arv_sak
{

    
    class Databas
    {
         List<Sak> databas;
         
         public Databas()
         {
             databas = new List<Sak>();
             CD cds = new CD("Narnia", "Erik");
             databas.Add(cds);
             CD cds1 = new CD("Harry potter", "Casper");
             databas.Add(cds1);
             DVD dvds = new DVD("DVD, Lord of the rings,", "Peter jacksson");
             databas.Add(dvds);
             DVD dvds1 = new DVD("DVD, The two towers", "Peter jacksson");
             databas.Add(dvds1);
             DVD dvds2 = new DVD("DVD, The return of the king", "Peter jacksson");
             databas.Add(dvds2);


             foreach(Sak sak in databas)
             {
                sak.Act();
             }
            
             
             



         }

         


    }


}