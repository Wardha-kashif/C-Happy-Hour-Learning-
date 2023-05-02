using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
     class Inheritance
    {
        public String brand = "suzuki";

        public void printDetails()
        {
            Console.WriteLine("This is the Parent merhod");
        }
    }

    class Child:Inheritance
    {
        public string modelname = "A6887";

    }

    //If you don't want other classes to inherit from a class, use the sealed keyword:
}
