using System;

class Program
{
       static void Main(string[] args)
      {
         //uppgift_1A();
         //uppgift_1B();
         //uppgift_2A();
         //uppgift_2B();
         //uppgift_3A();
         //uppgift_3B();
         //uppgift_3C();
         //uppgift_4A();
         //uppgift_4B();
         //uppgift_4C();
         //uppgift_5();
         //uppgift_6();
         //uppgift_7_8A_8B();
         Uppgift9A();  
         


         

         

            

      
                                        
              



       }

      
      static void Uppgift_1A()
      {
              Console.WriteLine("Vad heter du?");
                String namn = Console.ReadLine();
                Console.WriteLine("Välkommen " + namn + "!");
                Console.WriteLine();
      }

      static void Uppgift_1B()
      {
              double bredd = 9.6;
                double höjd = 5.4;
                double area;
                area = bredd * höjd / 2;
                Console.WriteLine("triangel");
                Console.WriteLine("bredd: " + bredd);
                Console.WriteLine("höjd: " + höjd);
                Console.WriteLine("area: " + area);
                Console.WriteLine();
      }

      static void Uppgift_2A()
      {
          Random randomObjekt = new Random();
        int slumpatTal = randomObjekt.Next(1, 11);
          Console.Write("Gissa på ett tal mellan 1 och 10 ");
          string indata = Console.ReadLine();
          int gissatTal = Convert.ToInt32(indata);
          if (gissatTal == slumpatTal)
          {
            Console.WriteLine("Rätt gissat!");
          }
          else
          {
            Console.WriteLine("Fel! Rätt tal är: " + slumpatTal);
          }
          Console.ReadLine();
              
      }
      static void uppgift_3A()
      {
      
          int räknare = 1;
          while (räknare < 6)
          {
            Console.WriteLine("" + räknare);
            räknare = räknare + 1;   
          }
          Console.WriteLine();

      }

      static void uppgift_3B()
      {
        int räknare = 5;
        while (räknare < 21)
        {
            Console.WriteLine("" + räknare);
            räknare = räknare + 3;   
        }
        Console.WriteLine();
      } 

      static void uppgift_3C()
      { int räknare = 10;
          while (räknare > -1)
          {
            Console.WriteLine("" + räknare);
            räknare = räknare - 1;   
          }
          Console.WriteLine();
      }

      static void uppgift_4A()
      {for (int i = 1; i < 6; i = i + 1)
            {
                Console.WriteLine("" + i);
            } 
      }

      static void uppgift_4B()
      {
      for (int i = 5; i < 21; i = i + 3)
            {
                Console.WriteLine("" + i);
            }
      }   

      static void uppgift_4C()
      {for (int i = 10; i > -1; i = i - 1)
            {
                Console.WriteLine("" + i);
            }
       }

      static void uppgift_5()
      {  Console.WriteLine("Gissa på ett tal!");
       string svar;
      svar = Console.ReadLine();
      while(svar != "15")
      {
        Console.WriteLine("Gissa igen!");
       svar = Console.ReadLine();

      }
       Console.WriteLine("Du gissade rätt!");
       }


      static void uppgift_6()
      {
       Random rG1 = new Random();
       Random rG2 = new Random();
       int aö1 = rG1.Next(1, 7);
       Console.WriteLine(aö1);
       int aö2 = rG2.Next(1, 7);
       Console.WriteLine(aö2);
       if(aö1 == 6 && aö2 == 6)
       {
         Console.WriteLine("Stor vinst");
       }
       else if(aö1 == aö2 )
       {
         Console.WriteLine("Liten vinst");
       }
       else
       {
         Console.WriteLine("Förlust");
       }
      }

      static void uppgift_7_8A_8B()
      {
         String[] lista = { "3", "5", "7", "9", "11", "13" };
            Console.WriteLine(lista[0]);
            Console.WriteLine(lista[1]);
            Console.WriteLine(lista[2]);
            Console.WriteLine(lista[3]);
            Console.WriteLine(lista[4]);
            Console.WriteLine(lista[5]);
            Console.WriteLine();

            int[] tal = new int[6];
            tal[0] = 3;
            tal[1] = 5;
            tal[2] = 7;
            tal[3] = 9;
            tal[4] = 11;
            tal[5] = 13;
             for(int i = 0; i < 6; i = i + 1)
            {
              Console.WriteLine(tal[i]);
            }
            for(int i = 0; i < 6; i = i + 1)
            {
              tal[i] = tal[i] + 1;
            }

            foreach(int talet in tal)
            {
              Console.WriteLine(talet);
            }


            
       }
       static void Uppgift9A()
       {

       }      

 


     

      
}

