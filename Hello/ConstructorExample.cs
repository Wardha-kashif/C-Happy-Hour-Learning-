using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    internal class ConstructorExample
    {
        public string model;
        public string color;
        public int year;

        // Create a class constructor with multiple parameters
        public ConstructorExample(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;

            Console.WriteLine("Model" + model);
            Console.WriteLine("Color" + color);
            Console.WriteLine("Year" + year);

        }
    }
}
