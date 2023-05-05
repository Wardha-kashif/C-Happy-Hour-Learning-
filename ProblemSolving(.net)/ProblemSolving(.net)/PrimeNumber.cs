using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_.net_
{
    public class PrimeNumber
    {

        public PrimeNumber()

        {
            bool isPrime = true;
            Console.WriteLine("Enter the number you want to find out whether it is a prime or not");
            int userInput = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= userInput / 2; i++)
            {
                if (userInput % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("This is the Prime Number");
            }
            else
            {
                Console.WriteLine("This is not the prime number");
            }
        }
    }
}
