using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    public class LambdaExpression
    {
        static void Main()
        {
            // statement lambda that takes two int inputs and returns the sum 
            var resultingSum = (int a, int b) =>
            {
                int calculatedSum = a + b;
                return calculatedSum;
            };

            // find the sum of 5 and 6
            Console.WriteLine("Total sum: " + resultingSum(5, 6));
        }

    }
}
