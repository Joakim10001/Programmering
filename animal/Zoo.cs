using System;
using System.Collections.Generic;

namespace animal
{

    

    class Zoo
    {
       

        List<Animal> Djur; 
        public Zoo()
        {
            Djur =new List<Animal>();
            Dog minhund = new Dog(4);
            Djur.Add(minhund);
            Dog minhund1 = new Dog(3);
            Djur.Add(minhund1);
            Dog minhund2 = new Dog(2);
            Djur.Add(minhund2);




           

            Cat minkatt = new Cat(4);
            Djur.Add(minkatt);
            Cat minkatt1 = new Cat(3);
            Djur.Add(minkatt1);
            Cat minkatt2 = new Cat(2);
            Djur.Add(minkatt2);

            Cow minko = new Cow(4);
            Djur.Add(minko);
            Cow minko1 = new Cow(3);
            Djur.Add(minko1);
            Cow minko2 = new Cow(2);
            Djur.Add(minko2);

        }

        




        public void Run()
        {
           foreach (Animal animal in Djur)
        {
            animal.Act();
        } 
        
        
      
       
    }
    
} }