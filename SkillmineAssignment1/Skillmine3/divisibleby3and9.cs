using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject2
{
    class Divisibleby3and9
    {
        static void Main(string []args)
        {
            int num;
            Console.WriteLine("enter the number");
            num = int.Parse(Console.ReadLine());
            if (num % 3 == 0)
            {
                Console.WriteLine("divisible");

            }
            else if (num % 9 == 0)
            {
                Console.WriteLine("divisible");
            }
            else
            {
                Console.WriteLine(" non divisible");
            }

        }
    }
}
