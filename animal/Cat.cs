using System;

namespace animal
{

    class Cat : Animal
    {

        private int age;

       public Cat(int age1)
       {
           age = age1;
       }

       public void Act()
       {
         Console.WriteLine("Mjau" + age);

       }
    }
}