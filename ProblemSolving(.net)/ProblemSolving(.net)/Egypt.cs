using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_.net_
{
    public class Egypt
    {

        public void EgyptFunc()
        {
          
                Console.WriteLine("Enter Sides of Traingle");
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                int num3 = Convert.ToInt32(Console.ReadLine());

                    if (num1 > 0 && num2 >  0 && num3 > 0)
                    {
                        if (num1 * num1 == num2 * num2 + num3 * num3)
                        {
                            Console.WriteLine("right");
                        }
                        if (num2 * num2 == num1 * num1 + num3 * num3)
                        {
                            Console.WriteLine("right");
                        }

                        if (num3 * num3 == num1 * num1 + num2 * num2)
                        {
                            Console.WriteLine("right");
                        }
                else
                {
                    Console.WriteLine("wrong");

                }
                    }
                    else
                    {
                        Console.WriteLine("wrong");
               
                    }
            }
        }
    }

