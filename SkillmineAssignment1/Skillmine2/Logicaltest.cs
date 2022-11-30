using System;
using System.Collections.Generic;
using System.Text;

namespace Skillminesproject3
{
    class Logicaltest
    {
        static void Main(string []args)
        {
            int year;
            int per;
            Console.WriteLine("Enter the Year");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Per");
            per = int.Parse(Console.ReadLine());
            
            if (year ==2022 && per >60)
            {
                Console.WriteLine("Selected");

            }
            else 
            {
                Console.WriteLine(" not Selected");
            }
        }
    }
}
