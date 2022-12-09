using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
   abstract class Fruits
    {
        //Abstract method does not have a body
        public abstract void FruitColour();

        public void getDetails()
        {
            Console.WriteLine("The details are shown here");
        }

       
    }
    //Inherit from fruits

    class Mango : Fruits {
        public override void FruitColour()
        {
            Console.WriteLine("The mango is yellow in color");

        }

    }

}
