using ProblemSolving_.net_;
using System;

namespace ProblemSolving_.net_
{
    public class FibonnaciSeries
    {
        public string FibonnaciSeriesFunc()
        {
            int n1 = 0, n2 = 1, n3;
            Console.WriteLine("Enter the Length of Fibonacci series");
            var numLength = Convert.ToInt32(Console.ReadLine());

            string output = "The Fibonacci series is " + "\n"+ n1 + "\n";
            
            for (int i = 1; i <= numLength; i++)
            {
                n3 = n1 + n2;
                n2 = n1;
                n1 = n3;
                output += n1 + "\n";
            }
            return output;
        }
    }
}

