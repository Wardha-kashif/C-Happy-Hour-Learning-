using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    internal class Encapsulation
    {
        private string name; // field

        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }
    }
}
