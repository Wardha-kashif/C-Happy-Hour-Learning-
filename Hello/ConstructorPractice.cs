using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    internal class ConstructorPractice

    {
        public String model;
        public ConstructorPractice(string modelName)
        {
            model = modelName;
            Console.WriteLine(model);
        }
    }
}
