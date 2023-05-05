using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
     interface Bird 
    {
        void birdSound();
    
    }

   class Parrot : Bird
    {
        public void birdSound()
        {
            Console.WriteLine("The parrot sound is psittacines");
        }
    }
}
