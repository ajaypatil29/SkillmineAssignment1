using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject2
{
    class Divisibleby5
    {
        static void Main(string []args)
        {
            int num;
            Console.WriteLine("enter the number");
            num = int.Parse(Console.ReadLine());
            if (num % 5 == 0)
            {
                Console.WriteLine("number is divisible");

            }
            else
            {
                Console.WriteLine("number is non divisible");
            }
        }
    }
}
