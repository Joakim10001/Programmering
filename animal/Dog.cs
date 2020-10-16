using System;

namespace animal
{
    class Dog : Animal
    {   
        private int age;
        public Dog(int age1)
        {
            age = age1;
        }

        public void Act()
        {
            Console.WriteLine("vov" + age);
        }
    }
}