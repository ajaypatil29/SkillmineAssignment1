using System;
using System.Collections.Generic;
using System.Text;

namespace Skillmineproject2
{
    class Areaoftriangle
    {
        static void Main(string []args)
        {
            int length; 
            int Base;
            Console.WriteLine("enter the value of length");

            length = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value of Base");
        Base  = int.Parse(Console.ReadLine());
        double  area = 0.5*(length * Base);
            Console.WriteLine("Area :");
            Console.WriteLine(area );




        }


    }

   
}

