using System;
using System.Collections.Generic;
using System.Text;

namespace Skillminesproject3
{
    class Nestedtest2

    {
        static void Main(string[] args)
        {
            int year;
            int per;
            Console.WriteLine("Enter the Year");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Per");
            per = int.Parse(Console.ReadLine());
            if(year== 2022) 
            {
                if (per>60)
                {
                    Console.WriteLine("Student Selected");

                }
                else 
                {
                    Console.WriteLine("Student not Selected");
                }
               
            }
            else
            {
                Console.WriteLine("Student not Selected");
            }

        }
        
    }
}
