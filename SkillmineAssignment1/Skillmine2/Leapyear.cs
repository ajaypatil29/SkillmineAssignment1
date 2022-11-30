using System;
using System.Collections.Generic;
using System.Text;

namespace Skillminesproject3
{
    class Leapyear
    {
        static void Main(string []args)
        {
            int year;
            Console.WriteLine("enter the year");
            year = int.Parse(Console.ReadLine());
            if (year%4==0)
            {
                Console.WriteLine("leap year ");

            }
            else
            {
                Console.WriteLine("not a leap year");
            }
        }
    }
}
