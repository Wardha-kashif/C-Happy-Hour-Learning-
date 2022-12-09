using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    class Animal
    {
    public virtual void animalSound()
        {
            Console.WriteLine("This is the base class sound");
        }
    }
    class Dog:Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("This is the dog class sound");
        }
    }
    class Cat : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("This is the Cat class sound");
        }
    }
}
