using System;
using System.Collections.Generic;
using System.Text;

namespace Hello.Classes
{
    public class Animal
    {
        private readonly string name;

        public Animal(string name)
        {
            this.name = name;
        }

        public void PrintName()
        {
            Console.WriteLine(name);
        }
    }
}
