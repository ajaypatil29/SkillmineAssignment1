using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject2
{
    class OddorEven
    {
        static void Main(string []args)
        {
            int num;
            Console.WriteLine("enter the number:");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) 
            {
                Console.WriteLine("EVEN");

            }
            else
            {
                Console.WriteLine("odd");

            }
        }
    }
}
