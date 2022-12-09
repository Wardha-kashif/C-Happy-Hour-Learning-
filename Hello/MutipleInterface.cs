using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    internal interface MutipleInterface1
    {
        void methodOne();
    }
    internal interface MutipleInterface2
    {
        void methodTwo();
    }
    public class ImplementInterface
    {
        public void methodOne() {
            Console.WriteLine("This is the method one");
        }
        public void methodTwo() {

            Console.WriteLine("This is the method two");
        }
    }

}
